using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data.MySqlClient;

namespace Ch10
{
    internal class _1_DBConnection
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
