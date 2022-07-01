using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class DBAccess
    {
        static DBAccess instance = new DBAccess();

        public DBAccess() { }

        internal static DBAccess Instance { get => instance; }

        const string SERVER = "127.0.0.1";
        const string PORT = "3306";
        const string USERNAME = "root";
        const string PASSWORD = "1234";
        const string DATABASE = "testdb";
        const string TABLE = "user2";


        MySqlConnection Connect()
        {
            string strConn = $"server={SERVER};";
            strConn += $"port={PORT};";
            strConn += $"username={USERNAME};";
            strConn += $"password={PASSWORD};";
            strConn += $"database={DATABASE};";

            MySqlConnection conn = new MySqlConnection(strConn);

                return conn;
        }

        public void InsertUser(string uid, string name, string hp ,decimal age)
        {
            MySqlConnection conn = Connect();

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand(); ;
                cmd.CommandText = $"INSERT INTO `{TABLE}` VALUES('{uid}','{name}','{hp}',{age})";

                MySqlDataReader reader = cmd.ExecuteReader();


            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                conn.Close();

            }
        }
        public void UpdateUser(string uid, string name, string hp , decimal age)
        {
            MySqlConnection conn = Connect();

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand(); ;
                cmd.CommandText = $"UPDATE {TABLE} SET `name` = '{name}'," +
                    $"`hp` = '{hp}', `age` = {age} where `uid` = '{uid}'";
                cmd.ExecuteNonQuery();

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                conn.Close();

            }
            MessageBox.Show("데이터가 저장되었습니다.", "Update 완료");
        }
        public void SelectUser()
        {

        }
        public List<User> SelectUsers()
        {
            MySqlConnection conn = Connect();
            List<User> users = new List<User>();

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand(); ;
                cmd.CommandText = "SELECT * FROM `user2`";

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    User user = new User();
                    user.Uid = reader[0].ToString();
                    user.Name = reader[1].ToString();
                    user.Hp = reader[2].ToString();
                    user.Age = Convert.ToInt32(reader[3]);

                    users.Add(user);
                }

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                conn.Close();

            }
            return users;
        }
        public void DeleteUser(string uid)
        {
            MySqlConnection conn = Connect();

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand(); ;
                cmd.CommandText = $"Delete from `{TABLE}` where `uid` = '{uid}'";
                cmd.ExecuteNonQuery();

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                conn.Close();

            }
            MessageBox.Show("데이터가 저장되었습니다.", "Delete 완료");
        }

    }
}
