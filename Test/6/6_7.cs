using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._6
{
    class Person
    {
        public string name { get; set; }
        public int age { get; set; }
        public List<int> Scores { get; set; }
    }
    internal class _6_7
    {
        static void Main1(string[] args)
        {
            Person[] people =
            {
                new Person(){name = "김유신", age= 25, Scores = new List<int>() {60,70,80}},
                new Person(){name = "김춘추", age= 21, Scores = new List<int>() {70,72,81}},
                new Person(){name = "장보고", age= 35, Scores = new List<int>() {68,82,76}},
                new Person(){name = "강감찬", age= 45, Scores = new List<int>() {88,90,82}},
                new Person(){name = "이순신", age= 55, Scores = new List<int>() {92,96,84}},
            };

            var result = from p in people
                         where p.Scores.Average() >= 60
                         orderby p.Scores.Average() descending
                         select new { Name = p.name,
                         Age = p.age,
                         Sum = p.Scores.Sum(),
                         Avg = p.Scores.Average()
                         };

            foreach (var p in result)
                Console.WriteLine($"{p.Name}, {p.Age}, {p.Sum}, {p.Avg}");

        }
    }
}
