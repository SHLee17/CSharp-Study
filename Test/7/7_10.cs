using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._7
{
    internal class _7_10
    {
        static void Main1(string[] args)
        {
            string s = "before";
            Console.WriteLine(s);

            Test(s);
                Console.WriteLine(s);
            Test(ref s);
            Console.WriteLine(s);
        }

        static void Test(string s) => s = "after";
        static void Test(ref string s) => s = "after";
    }
}
