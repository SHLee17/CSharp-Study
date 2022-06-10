using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1
{
    internal class _2_10
    {
        static void Main1(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                int temp = fibo(i);
                Console.Write(temp + " ");
            }
        }

        public static int fibo(int n)
        {
            if (n <= 1) return n;

            return fibo(n-1) + fibo(n-2);
        }


        /*
         * ex)
         * 5  = 5
         * n1 4
         * 4 - 1                      4 - 2
         * 3 - 1        3 - 2         2 - 1 2 - 2
         * 2 - 1 2 - 2  (1)           (1)
         * (1)
         * 
         * n2 3 
         * 3 - 1                      3 - 2
         * 2 - 1 2 - 2                (1)
         * (1)
         */
    }
}
