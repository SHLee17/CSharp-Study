using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._10
{
    class User
    {
        string uid;
        string name;
        int age;
        bool isMarried;

        public User(string uid, string name, int age, bool isMarried)
        {
            this.Uid = uid;
            this.Name = name;
            this.Age = age;
            this.IsMarried = isMarried;
        }

        public string Uid { get => uid; set => uid = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public bool IsMarried { get => isMarried; set => isMarried = value; }

        public override string ToString()
        {
            return $"아이디 : {uid}, 이름 : {name}, 나이 : {age}, 결혼여부 : {isMarried}";
        }
    }
    class UserHashTable
    {
        Hashtable users;
        public UserHashTable() => users = new Hashtable();
        public void AddUser(User user) => users.Add(user.Uid, user);
        public bool RemoveUser(string uid)
        {
            if (users.ContainsKey(uid))
            {
                users.Remove(uid);
                return true;
            }
            Console.WriteLine("아이디 '{0}'가 존재하지 않습니다.", uid);
            return false;
        }
        public void ShowAllUsers()
        {
            foreach  (User user in users.Values)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}",user.Uid,user.Name,user.Age,user.IsMarried);
            }
        }
    }

    internal class _10_10
    {
        static void Main(string[] args)
        {
            UserHashTable ht = new UserHashTable();

            ht.RemoveUser("kim");

            User user1 = new User("a101", "김유신", 23, false);

            ht.AddUser(user1);

            ht.ShowAllUsers();
        }
        
    }
}
