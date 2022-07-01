﻿using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._6
{
    class User
    {
        string uid;
        string name;
        string hp;
        int age;

        public string Uid { get => uid; set => uid = value; }
        public string Name { get => name; set => name = value; }
        public string Hp { get => hp; set => hp = value; }
        public int Age { get => age; set => age = value; }
    }

    class DataManager
    {
        const string SERVER = "127.0.0.1";
        const string PORT = "3306";
        const string USERNAME = "root";
        const string PASSWORD = "1234";
        const string DATABASE = "testdb";
        const string TABLE = "user2";

        static DataManager instance = new DataManager();
        public static DataManager Instance { get { return instance; } }
        
        public MySqlConnection Connect()
        {
            string strConn = $"server={SERVER};";
            strConn += $"port={PORT};";
            strConn += $"username={USERNAME};";
            strConn += $"password={PASSWORD};";
            strConn += $"database={DATABASE};";

            MySqlConnection conn = new MySqlConnection(strConn);
            return conn;
        }
        public int InsertUser()
        {
            Console.Write("아이디 : ");
            string uid = Console.ReadLine();
            Console.Write("이름 : ");
            string name = Console.ReadLine();
            Console.Write("휴대폰 : ");
            string hp = Console.ReadLine();
            Console.Write("나이 : ");
            int age = int.Parse(Console.ReadLine());

            MySqlConnection conn = null;
            int count = 0;

            try
            {
                conn = Connect();
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText =$"INSERT INTO `{TABLE}`" +
                            $"VALUES ('{uid}','{name}','{hp}',{age})";

                count = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }

            return count;
        }

        public User SelectUser()
        {
            Console.Write("이름검색 : ");
            string name = Console.ReadLine();

            User user = null;
            MySqlConnection conn = null;

            try
            {
                conn = Connect();
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT * FROM `{TABLE}` WHERE `name`='{name}'";

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    user = new User();
                    user.Uid = reader[0].ToString();
                    user.Name = reader[1].ToString();
                    user.Hp = reader[2].ToString();
                    user.Age = int.Parse(reader[3].ToString());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }

            return user;
        }

        public List<User> SelectUserAll()
        {
            List<User> users = new List<User>();
            MySqlConnection conn = null;

            try
            {
                conn = Connect();
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT * FROM `{TABLE}`";
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    User user = new User();
                    user.Uid = reader[0].ToString();
                    user.Name = reader[1].ToString();
                    user.Hp = reader[2].ToString();
                    user.Age = int.Parse(reader[3].ToString());

                    users.Add(user);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }

            return users;
        }

        public int DeleteUser()
        {
            Console.Write("이름삭제 : ");

            string name = Console.ReadLine();

            MySqlConnection conn = null;

            int count = 0;

            try
            {
                conn = Connect();
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"DELETE FROM `{TABLE}`WHERE `name`='{name}'";
                count = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }

            return count;
        }
    }
    internal class _6_10
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("***************************");
            Console.WriteLine("데이터 매니저 프로그램 v2.0");
            Console.WriteLine("***************************");

            DataManager dm = DataManager.Instance;

            while (true)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("종료:0, 입력:1, 전체조회:2, 이름조회:3, 삭제:4");

                int answer = int.Parse(Console.ReadLine());

                if (answer == 0) break;

                else if( answer == 1)
                {
                    int count = dm.InsertUser();
                    if(count > 0)
                        Console.WriteLine("입력 완료!");
                }
                else if( answer == 2)
                {
                    List<User> users = dm.SelectUserAll();

                    Console.WriteLine("-------------전체결과------------");
                    foreach (User item in users)
                    {
                        Console.WriteLine("{0},{1},{2},{3}", item.Uid,item.Name,item.Hp,item.Age);
                    }
                }
                else if(answer == 3)
                {
                    User user = dm.SelectUser();
                    Console.WriteLine("-------------전체결과------------");
                    Console.WriteLine("{0},{1},{2},{3}", user.Uid, user.Name, user.Hp, user.Age);
                }
                else if(answer == 4)
                {
                    int count = dm.DeleteUser();
                    Console.WriteLine("{0}건 삭제 완료!", count) ;
                }
            }
            Console.WriteLine("프로그램 종료...");
        }
    }
}
