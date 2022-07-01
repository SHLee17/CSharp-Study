using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._8
{
    internal class _8_7
    {
        static void Main1(string[] args)
        {
            bool sign = false;
            double pi = 0;

            for (int i = 1; i < 1000; i += 2)
            {
                if(!sign)
                {
                    pi += 1.0 / i;
                    sign = true;
                }
                else
                {
                    pi -= 1.0 / i;
                    sign = false;
                }
                Console.WriteLine("i = {0}, PI = {1}", i, 4*pi);
            }
        }
    }
}
