using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInfoConsole
{
    class dbworker
    {
        MySqlConnection Connection;
        MySqlConnectionStringBuilder mySqlConnectionStringBuilder = new MySqlConnectionStringBuilder();
        public dbworker()
        {
            mySqlConnectionStringBuilder.Server = "localhost";
            mySqlConnectionStringBuilder.UserID = "root";
            mySqlConnectionStringBuilder.Password = "";
            mySqlConnectionStringBuilder.Port = 3306;
            mySqlConnectionStringBuilder.Database = "comps";
            mySqlConnectionStringBuilder.CharacterSet = "utf8";
            Connection = new MySqlConnection(mySqlConnectionStringBuilder.ConnectionString);
        }

        public long UploadComp(string inventNomer, string kabinet, string n_pc)
        {
            MySqlCommand comm = Connection.CreateCommand();
            comm.CommandText = "INSERT INTO comps (`invent_no`, `kabinet`, `n_pc`) VALUES ('"+inventNomer+"', '"+kabinet+"', '"+n_pc+"');";

            try
            {
                Connection.Open();
                comm.ExecuteNonQuery();
                return comm.LastInsertedId;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Connection.Close();
            }
            return 0;
        }

        public void CreateTableComp()
        {
            MySqlCommand comm = Connection.CreateCommand();
            comm.CommandText = @"CREATE TABLE `comps` (
	`id` INT(11) NOT NULL AUTO_INCREMENT,
	`invent_no` VARCHAR(50) NULL DEFAULT NULL,
	`kabinet` VARCHAR(50) NULL DEFAULT NULL,
	`n_pc` VARCHAR(50) NULL DEFAULT NULL,
	PRIMARY KEY (`id`)
)
COLLATE='utf8mb4_general_ci'
ENGINE=InnoDB;";
            try
            {
                Connection.Open();
                comm.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Connection.Close();
            }
        }

        public void CreateTable(HWSW input, string TableName, string prefix)
        {
            List<string> keys = input.getKeys();
            List<string> columns = new List<string>();
            for (int i = 0; i < keys.Count; i++)
                columns.Add(prefix + keys[i]);

            MySqlCommand comm = Connection.CreateCommand();
            comm.CommandText = @"CREATE TABLE `" + TableName + "` (`id` INT NOT NULL AUTO_INCREMENT,";
            foreach (var column in columns)
            {
                comm.CommandText += "`" + column + "` VARCHAR(300) NULL,";
            }
            comm.CommandText += "`"+prefix+@"npc` INT(11) NULL,
	PRIMARY KEY (`id`),
	INDEX `FK_"+TableName+ @"_comp` (`" + prefix + @"npc`),
	CONSTRAINT `FK_" + TableName + @"_comp` FOREIGN KEY (`" + prefix + @"npc`) REFERENCES `comps` (`id`)) COLLATE='utf8_general_ci';";
            try
            {
                Connection.Open();
                comm.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Connection.Close();
            }
        }

        public void upload(HWSW input, string TableName, string prefix, long npc)
        {
            List<string> keys = input.getKeys();
            MySqlCommand comm = Connection.CreateCommand();

            List<string> columns = new List<string>();
            for (int i = 0; i < keys.Count; i++)
                columns.Add(prefix + keys[i]);

            comm.CommandText = "INSERT INTO "+TableName+" (" + String.Join(",", columns) + "," + prefix + @"npc) VALUES ";
            int n = 0;
            foreach (var obj in input.M_objects)
            {
                List<string> values = new List<string>();
                for (int i = 0; i < keys.Count; i++)
                    values.Add("?" + keys[i] + n.ToString());
                comm.CommandText += "(" + String.Join(",", values) + ",?npc"+ n.ToString() + "),";

                foreach (var parametr in keys)
                    comm.Parameters.Add("?" + parametr + n, MySqlDbType.VarChar).Value = obj[parametr];
                comm.Parameters.Add("?npc"+n.ToString(), MySqlDbType.Int32).Value = npc;
                n++;
            }
            comm.CommandText = comm.CommandText.Substring(0, comm.CommandText.Length-1);
            try
            {
                Connection.Open();
                comm.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
