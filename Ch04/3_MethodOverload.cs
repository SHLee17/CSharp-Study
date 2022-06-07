using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch04
{
    internal class _3_MethodOverload
    {
        static void Main(string[] args)
        {
            int r1 = Plus(1, 2);
            int r2= Plus(1, 2, 3);
            double r3 = Plus(1.01, 2.3);
            string r4 = Plus("Hello", "World");

            Console.WriteLine("r1 : " + r1);
            Console.WriteLine("r2 : " + r2);
            Console.WriteLine("r3 : " + r3);
            Console.WriteLine("r4 : " + r4);


        }
        public static int Plus(int a, int b)
        {
            return a +b;
        }
        public static int Plus(int a, int b,int c)
        {
            return a+b+c;
        }
        public static double Plus(double a, double b)
        {
            return a + b;
        }
        public static string Plus(string a, string b)
        {
            return a + b;
        }
        
    }
}
