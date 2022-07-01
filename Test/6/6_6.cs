using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._6
{
    class Student
    {
        string name;
        int age;
        int score;

        public Student(string name, int age, int score)
        {
            this.Name = name;
            this.Age = age;
            this.Score = score;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public int Score { get => score; set => score = value; }
    }
    internal class _6_6
    {
        static void Main1(string[] args)
        {
            List<Student> students = new List<Student>();

            students.Add(new Student("이순신", 55, 96));
            students.Add(new Student("장보고", 35, 88));
            students.Add(new Student("김유신", 25, 86));
            students.Add(new Student("김춘추", 23, 76));
            students.Add(new Student("강감찬", 45, 62));

            var result = from s in students
                         orderby s.Score descending
                         group s by s.Score >= 80 into g
                         select new
                         {
                             GroupKey = g.Key,
                             Groups = g
                         };

            foreach (var item in result)
            {
                Console.WriteLine();
                Console.WriteLine("80점 이상 : " + item.GroupKey );

                foreach (var s in item.Groups)
                    Console.WriteLine("{0}, {1}, {2}", s.Name, s.Age, s.Score);
            }
        }

    }
}
