using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._9
{
    internal class _9_9
    {
        static void Main1(string[] args)
        {
            Print(10);
            Print(0.123);
            Print("Sum = ", 123.4);
        }

        static void Print(double x) => Console.WriteLine(x);
        static void Print(string s, double x) => Console.WriteLine(s + x);
        static void Print(int x) => Console.WriteLine(x);
    }
}
