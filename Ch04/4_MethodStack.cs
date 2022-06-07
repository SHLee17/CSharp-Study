using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch04
{
    internal class _4_MethodStack
    {
        static void Main(string[] args)
        {
            int result = 0;
            int n1 = 1;
            int n2 = 2;
            result = sum(n1, n2);

            Console.WriteLine("result : " + result);
        }

        public static int sum(int start, int end)
        {
            int total = 0;
            for (int i = start; i <= end; i++)
                total += i;
            return total;
        }
    }
}
