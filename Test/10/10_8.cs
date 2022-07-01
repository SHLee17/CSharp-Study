﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._10
{
    class Member
    {
        public string Name { get; init; }
        public string HP { get; init; }
        public int Age { get; init; }

        public override string ToString()
        {
            return $"{Name}, {HP}, {Age}";
        }
    }
    internal class _10_8
    {
        static void Main1(string[] args)
        {


            Member m1 = new Member { Name = "김유신", HP = "010-1234-1001", Age = 25 };
            Member m2 = new Member { Name = "김춘추", HP = "010-1234-1002", Age = 23 };
            Member m3 = new Member { Name = "장보고", HP = "010-1234-1003", Age = 37 };

            var m4 = new { Name = "강감찬", HP = "010-1234-1004", Age = 41 };
            var m5 = new { Name = "이순신", HP = "010-1234-1005", Age = 52 };

            Console.WriteLine(m1);
            Console.WriteLine(m2);
            Console.WriteLine(m3);
            Console.WriteLine(m4);
            Console.WriteLine(m5);

        }
    }
}
