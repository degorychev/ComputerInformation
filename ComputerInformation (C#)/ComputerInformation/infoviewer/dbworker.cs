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
        public dbworker(string server, string user, string pass, string database)
        {
            mySqlConnectionStringBuilder.Server = server;
            mySqlConnectionStringBuilder.UserID = user;
            mySqlConnectionStringBuilder.Password = pass;
            mySqlConnectionStringBuilder.Port = 3306;
            mySqlConnectionStringBuilder.Database = database;
            mySqlConnectionStringBuilder.CharacterSet = "utf8";
            Connection = new MySqlConnection(mySqlConnectionStringBuilder.ConnectionString);
        }
        public bool online()
        {
            MySqlCommand comm = Connection.CreateCommand();
            comm.CommandText = "SELECT 1";

            try
            {
                Connection.Open();
                comm.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Connection.Close();
            }
            return false;
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
