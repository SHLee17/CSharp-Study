using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class User
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
}
