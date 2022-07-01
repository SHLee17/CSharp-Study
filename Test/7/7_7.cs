using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._7
{
    internal class _7_7
    {
        static void Main1(string[] args)
        {
            Console.Write("더하고자 하는 숫자들을 입력 : ");
            string s = Console.ReadLine();
            Console.WriteLine(s);

            int sum = 0;
            string[] v = s.Split();

            foreach (string item in v)
                sum += int.Parse(item);

            Console.WriteLine(sum);

        }
    }
}
