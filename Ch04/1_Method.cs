using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch04
{
    // p265
    internal class _1_Method
    {
        static void Main1(string[] args)
        {
            int r1 = F(1);
            int r2 = F(2);
            int r3 = F(3);

            Console.WriteLine("r1 : " + r1);
            Console.WriteLine("r2 : " + r2);
            Console.WriteLine("r3 : " + r3);

            int t1 = Sum(1, 10);
            int t2 = Sum(1, 100);
            int t3 = Sum(start: 1, end:1000);
        }

        public static int F(int x)
        {
            int y = 2 * x + 3;
            return y;
        }

        public static int Sum(int start, int end)
        {
            int total = 0;
            for (int i = start; i <= end; i++)
                total += i;
            return total;
        }
    }
}
