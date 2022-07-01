using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3
{
    internal class _3_04
    {

        class Student
        {
            static public int studentId;
            string name;
            string major;
            int grade;

            public Student(string name, string major, int grade)
            {
                studentId++;
                this.name = name;
                this.major = major;
                this.grade = grade;
            }

            public void Show()
            {
                Console.WriteLine("학번 : " + studentId);
                Console.WriteLine("이름 : " + name);
                Console.WriteLine("전공 : " + major);
                Console.WriteLine("학년 : " + grade);
                Console.WriteLine();
            }
        }
        static void Main1(string[] args)
        {
            Student.studentId = 20201000;

            Student kim = new Student("김유신", "국문과", 1);
            kim.Show();
            Student lee = new Student("이순신", "경제학과", 1);
            lee.Show();
            Student lim = new Student("임꺽정", "경영학과", 1);
            lim.Show();



        }
    }
}
