using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._4
{

    class Person
    {
        string name;
        int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Hello()
        {
            Console.WriteLine("이름 : " + name);
            Console.WriteLine("나이 : " + age);

        }
    }

    class Student : Person
    {
        string school;
        string major;

        public Student(string name, int age, string school, string major) : base(name, age)
        {
            this.school = school;
            this.major = major;
        }

        public new void Hello()
        {
            base.Hello();
            Console.WriteLine("학교 : " + school);
            Console.WriteLine("전공 : " + major);
        }
    }

    class SalaryStudent : Student
    {
        string company;

        public SalaryStudent(string name, int age, string school, string major, string company)
            : base(name, age, school, major)
        {
            this.company = company;
        }
        public new void Hello()
        {
            base.Hello();
            Console.WriteLine("회사 : " + company);
        }
    }

    internal class _4_9
    {
        
        static void Main1(string[] args)
        {
            Person kim = new Person("김유신", 24);
            Student jang = new Student("장보고", 26, "부경대", "영문학과");
            SalaryStudent lee = new SalaryStudent("이순신", 27, "부산대", "경재학과", "삼성전자");

            kim.Hello();
            Console.WriteLine("================================");

            jang.Hello();
            Console.WriteLine("================================");

            lee.Hello();
            Console.WriteLine("================================");
        }

    }

}