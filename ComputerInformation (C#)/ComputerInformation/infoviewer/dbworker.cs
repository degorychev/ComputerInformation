using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace infoviewer
{
    class dbworker
    {
        MySqlConnection Connection;
        MySqlConnectionStringBuilder mySqlConnectionStringBuilder = new MySqlConnectionStringBuilder();
        public dbworker()
        {
            mySqlConnectionStringBuilder.Server = "127.0.0.1";
            mySqlConnectionStringBuilder.UserID = "root";
            mySqlConnectionStringBuilder.Password = "";
            mySqlConnectionStringBuilder.Port = 3306;
            mySqlConnectionStringBuilder.Database = "ComputerInformation";
            mySqlConnectionStringBuilder.CharacterSet = "utf8";
            Connection = new MySqlConnection(mySqlConnectionStringBuilder.ConnectionString);
        }

        public DataTable getInfo(int n_pc, string TableName)
        {
            MySqlCommand cmd = Connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM "+ TableName + " WHERE `"+ TableName + "_npc` = ?npc";
            cmd.Parameters.Add("?npc", MySqlDbType.Int32).Value = n_pc;


            DataTable dt = new DataTable();
            try
            {
                Connection.Open();
                dt.Load(cmd.ExecuteReader());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Connection.Close();
            }
            return dt;
        }

        public DataTable getComps()
        {
            MySqlCommand cmd = Connection.CreateCommand();
            cmd.CommandText = "SELECT CONCAT(kabinet, '(', n_pc, ') - ', invent_no) AS 'name', id FROM comps";

            DataTable dt = new DataTable();
            try
            {
                Connection.Open();
                dt.Load(cmd.ExecuteReader());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Connection.Close();
            }
            return dt;
        }
    }
}
