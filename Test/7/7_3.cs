using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._7
{
    internal class _7_3
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("{0:N2}", 12345.5678);
            Console.WriteLine("{0:D8}", 1234);
            Console.WriteLine("{0:F3}", 1234.56);
            Console.WriteLine("{0,8}", 1234);
            Console.WriteLine("{0,8}", 1234);

            string str1 = string.Format("{0:N2}", 1234.5678);
            string str2 = string.Format("{0:D8}", 1234);
            string str3 = string.Format("{0:F3}", 1234.56);

            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);

            Console.WriteLine(1234.5678.ToString("N2"));
            Console.WriteLine(1234.ToString("D8"));
            Console.WriteLine(1234.56.ToString("F3"));

            Console.WriteLine("{0:#.##}", 1234.5678);
            Console.WriteLine("{0:#.#.##}", 1234.5678);
            Console.WriteLine("{0:000000.00}", 1234.5678);

            Console.WriteLine();

            for (int i = 0; i < 51; i++)
            {
                Console.Write(" {0,3} {1}", i, i % 10 != 0 ? " " : "\n");
            }

        }
    }
}
