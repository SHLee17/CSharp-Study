using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10
{
    internal class _2_Insert
    {
        static void Main1(string[] args)
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
                cmd.CommandText = "Insert INTO `test1` Values ('c101', '부산피바다', '010-1234-1010' ,27, '조선');";
                cmd.ExecuteNonQuery();
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
