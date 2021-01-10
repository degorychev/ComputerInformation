using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputerInformation
{
    public struct infoStruct
    {
        public bool isOk;
        public string info;
    }
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
            mySqlConnectionStringBuilder.Database = "test";
            mySqlConnectionStringBuilder.CharacterSet = "utf8";
            Connection = new MySqlConnection(mySqlConnectionStringBuilder.ConnectionString);
        }

        public infoStruct SendComp(string json)
        {
            infoStruct output = new infoStruct();
            var jarr = JArray.Parse(json);
            foreach (var i in jarr)
            {
                var data = JArray.Parse(JObject.Parse(i.ToString())["value"].ToString());
                foreach (var value in data)
                {
                    Console.WriteLine(value);
                }

            }
            return output;
        }

        public infoStruct test()
        {
            MySqlCommand comm = Connection.CreateCommand();
            infoStruct output = new infoStruct();
            try
            {
                Connection.Open();
                output.info = "Подключено к серверу "+ mySqlConnectionStringBuilder.Server;
                output.isOk = true;
                                
            }
            catch (Exception e)
            {
                output.isOk = false;
                output.info = e.Message;
            }
            finally            
            {
                Connection.Close();
            }
            return output;
        }

        public void upload(HWSW input)
        {
            var command = input.CreateTable(Connection, "CPU", "CPU_");
            try
            {
                Connection.Open();
                command.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Connection.Close();
            }
            command = input.GetInsertString(Connection, "CPU_");
            try
            {
                Connection.Open();
                command.ExecuteNonQuery();
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

        public infoStruct SendInformation(comp input)
        {

            MySqlCommand comm = Connection.CreateCommand();
            infoStruct output = new infoStruct();
            comm.CommandText = "INSERT INTO comps (invent_no, kabinet, n_comp, CPU, MB, GC, STOR, HDD, RAM, DEV, OS, NET, MEM, SOFT) " +
                "VALUES (?invent_no, ?kabinet, ?n_comp, ?CPU, ?MB, ?GC, ?STOR, ?HDD, ?RAM, ?DEV, ?OS, ?NET, ?MEM, ?SOFT);";
            comm.Parameters.Add("?invent_no", MySqlDbType.Int32).Value = input.invent_no;
            comm.Parameters.Add("?kabinet", MySqlDbType.VarChar).Value = input.kabinet;
            comm.Parameters.Add("?n_comp", MySqlDbType.VarChar).Value = input.n_comp;
            comm.Parameters.Add("?CPU", MySqlDbType.LongText).Value = input.CPU;
            comm.Parameters.Add("?MB", MySqlDbType.LongText).Value = input.MB;
            comm.Parameters.Add("?GC", MySqlDbType.LongText).Value = input.GC;
            comm.Parameters.Add("?STOR", MySqlDbType.LongText).Value = input.STOR;
            comm.Parameters.Add("?HDD", MySqlDbType.LongText).Value = input.HDD;
            comm.Parameters.Add("?RAM", MySqlDbType.LongText).Value = input.RAM;
            comm.Parameters.Add("?DEV", MySqlDbType.LongText).Value = input.DEV;
            comm.Parameters.Add("?OS", MySqlDbType.LongText).Value = input.OS;
            comm.Parameters.Add("?NET", MySqlDbType.LongText).Value = input.NET;
            comm.Parameters.Add("?MEM", MySqlDbType.LongText).Value = input.MEM;
            comm.Parameters.Add("?SOFT", MySqlDbType.LongText).Value = input.SOFT;
            try
            {
                Connection.Open();
                comm.ExecuteNonQuery();
                output.isOk = true;
            }
            catch(Exception ex)
            {
                output.isOk = false;
                output.info = ex.Message;
            }
            finally
            {
                Connection.Close();
                comm.Parameters.Clear();
            }

            return output; 
        }
    }
}
