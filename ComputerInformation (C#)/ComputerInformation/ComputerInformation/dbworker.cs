using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputerInformation
{
    class dbworker
    {
        MySqlConnection Connection;
        public dbworker()
        {
            MySqlConnectionStringBuilder mySqlConnectionStringBuilder = new MySqlConnectionStringBuilder();
            mySqlConnectionStringBuilder.Server = "localhost";
            mySqlConnectionStringBuilder.UserID = "root";
            mySqlConnectionStringBuilder.Password = "";
            mySqlConnectionStringBuilder.Port = 3306;
            mySqlConnectionStringBuilder.Database = "users_iatu";
            mySqlConnectionStringBuilder.CharacterSet = "UTF8";
            Connection = new MySqlConnection(mySqlConnectionStringBuilder.ConnectionString);
        }

        public string test()
        {
            MySqlCommand comm = Connection.CreateCommand();
            try
            {
                Connection.Open();
                Console.WriteLine("Connection successful!");
                comm.CommandText = "SELECT * FROM users LIMIT 25";

                MySqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader[0].ToString().PadRight(3) + " | " + reader[1].ToString().PadRight(15) + " | " + reader[2].ToString().PadRight(20) + " | " + reader[3].ToString().PadRight(20));
                }
                reader.Close();


                return "ok";
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            return "Error";
        }
    }
}
