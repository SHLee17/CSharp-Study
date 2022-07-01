﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._9
{
    internal class _9_6
    {
        static void Main1(string[] args)
        {
            int count = 0;
            for (int i = 2; i <= 100; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write("{0,3}", i);
                    count++;
                }
            }
            Console.WriteLine("\n2~100까지 소수는 모두 {0}개 입니다.", count);

            bool IsPrime (int x)
            {
                for (int i = 2; i < x; i++)
                {
                    if (x % i == 0)
                        return false;
                }
                return true;
            }
        }
    }
}
