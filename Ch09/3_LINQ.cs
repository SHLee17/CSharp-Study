using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch09
{
    class Member
    {
        string uid;
        string name;
        int age;

        public Member(string uid, string name, int age)
        {
            this.uid = uid;
            this.name = name;
            this.age = age;
        }

        public string Uid { get => uid; set => uid = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
    }

    internal class _3_LINQ
    {

        static void Main(string[] args)
        {

            List<int> dataList = new List<int>();
            for (int i = 1; i < 10; i++)
                dataList.Add(i);

            List<int> rList = new List<int>();
            List<int> rList1 = new List<int>();

            dataList.ForEach(n =>
            {
                if (n % 2 == 0)
                    rList.Add(n);
            });

            Console.WriteLine(string.Join(", ", rList));

            var r3 = from n in dataList where n >= 5 orderby n descending    select n;

            Console.WriteLine(string.Join(", ", r3));


            List <Member> memberList = new List<Member>();

            memberList.Add(new Member("a101", "김유신", 23));
            memberList.Add(new Member("a102", "김춘추", 25));
            memberList.Add(new Member("a103", "장보고", 35));
            memberList.Add(new Member("a104", "강감찬", 45));
            memberList.Add(new Member("a105", "이순신", 55));

            var r4 = from n in memberList where n.Age > 30 orderby n.Name descending select n;

            foreach (Member item in r4)
            {
                Console.WriteLine(item.Name);
            }


        }
    }
}
