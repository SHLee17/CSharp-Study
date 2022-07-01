﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._10
{
    class Human
    {
        string name;
        int age;

        public Human(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        protected void Hello()
        {
            Console.WriteLine("이름 : {0}",name);
            Console.WriteLine("나이 : {0}", age);
        }
    }
    class Student : Human
    {
        int studentId;

        public Student(string name, int age , int studentId) : base(name, age)
        {
            this.studentId = studentId;
        }
        public void Hello()
        {
            base.Hello();
            Console.WriteLine("학번 : {0}\n",studentId);
        }
    }

    class Worker : Human
    {
        int workerId;

        public Worker(string name, int age, int workerId) : base(name, age)
        {
            this.workerId = workerId;
        }
        public void Hello()
        {
            base.Hello();
            Console.WriteLine("사번 : {0}\n", workerId);
        }
    }
    internal class _10_4
    {
        static void Main1(string[] args)
        {
            Student kim = new Student("김철수", 21, 20201234);
            Worker lee = new Worker("이철수", 35, 20211201);

            kim.Hello();
            lee.Hello();
        }
    }
}
