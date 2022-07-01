using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10
{
    internal class _3_Select
    {
        static void Main(string[] args)
        {
            string sever = "127.0.0.1";
            string port = "3306";
            string userName = "root";
            string passWord = "1234";
            string dataBase = "testdb";

            string strConn = $"server={sever};port={port};username={userName};password={passWord};database={dataBase}";

            MySqlConnection conn = new MySqlConnection(strConn);

            try
            {
                conn.Open();
                Console.WriteLine("접속 성공...");

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "Select * from test1";

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine("{0},{1},{2},{3},{4}", reader[0], reader[1], reader[2], reader[3], reader[4]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("접속 실패 : " + e.Message);
            }
            finally
            {
                conn.Close();
                Console.WriteLine("접속 종료...");
            }
        }
    }
}
