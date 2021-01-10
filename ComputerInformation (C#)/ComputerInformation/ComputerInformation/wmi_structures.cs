using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace ComputerInformation
{
    public class HWSW //Типа HardWare_SoftWare
    {
        List<Dictionary<string, string>> M_objects = new List<Dictionary<string, string>>();

        public HWSW(IEnumerable<ManagementObject> objects)
        {
            foreach (var obj in objects)
            {
                Dictionary<string, string> values = new Dictionary<string, string>();
                foreach (var property in obj.Properties)
                {
                    if (!property.IsArray)
                        values.Add(property.Name, property.Value != null ? property.Value.ToString() : string.Empty);
                    else
                    {
                        var property_values = property.Value as string[];
                        values.Add(property.Name, property_values != null ? string.Join(",", property_values) : "");
                    }
                }
                M_objects.Add(values);
            }
        }

        public string print()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Объектов: " + M_objects.Count.ToString());
            int i = 0;
            foreach(var obj in M_objects)
            {
                sb.AppendLine(String.Format("Объект №" + i++));
                foreach(var value in obj.Keys)
                {
                    sb.AppendLine(String.Format("{0}: {1}", value, obj[value]));
                }
            }
            return sb.ToString();
        }

        public MySqlCommand CreateTable(MySqlConnection Connection, string tablename, string prefix)
        {
            MySqlCommand comm = Connection.CreateCommand();
            comm.CommandText = @"CREATE TABLE `" + tablename + "` (`id` INT NOT NULL AUTO_INCREMENT,";
            
            List<string> keys = M_objects[0].Keys.ToList();
            List<string> columns = new List<string>();
            for (int i = 0; i < keys.Count; i++)
                columns.Add(prefix + keys[i]);

            foreach(var column in columns)
            {
                comm.CommandText += "`" + column + "` VARCHAR(300) NULL,";
            }
            comm.CommandText += "PRIMARY KEY (`id`)) COLLATE='utf8_general_ci';";

            return comm;

        }

        public MySqlCommand GetInsertString(MySqlConnection Connection, string prefix)
        {
            List<string> keys = M_objects[0].Keys.ToList();
            MySqlCommand comm = Connection.CreateCommand();

            List<string> columns = new List<string>();
            for (int i = 0; i < keys.Count; i++)
                columns.Add(prefix + keys[i]);

            comm.CommandText = "INSERT INTO CPU (" + String.Join(",", columns) + ") VALUES ";
            int n = 0;
            foreach (var obj in M_objects)
            {
                List<string> values = new List<string>();
                for (int i = 0; i < keys.Count; i++)
                    values.Add("?" + keys[i] + n.ToString());
                comm.CommandText += "(" + String.Join(",", values) + ")";

                foreach (var parametr in keys)
                    comm.Parameters.Add("?"+parametr+n, MySqlDbType.VarChar).Value = obj[parametr];
                n++;
            }

            return comm;
        }
    }
}
