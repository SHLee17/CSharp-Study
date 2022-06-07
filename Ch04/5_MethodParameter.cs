using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch04
{
    internal class _5_MethodParameter
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 3;
            int num3 = 0;
            int num4 = 0;

            Divider1(num1, num2, ref num3, ref num4);

            Console.WriteLine("몫 : {0}, 나머지 : {1}" , num3, num4);

            Divider2(num1, num2, out num3, out num4);

            Console.WriteLine("몫 : {0}, 나머지 : {1}", num3, num4);

        }

        public static void Divider1(int a, int b, ref int quotient, ref int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }
        public static void Divider2(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }
    }
}
