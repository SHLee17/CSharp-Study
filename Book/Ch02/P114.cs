using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P114
    {
        static void Main1(string[] args)
        {
            double num = 42.273103;
            Console.WriteLine(num.ToString("0.0"));
            Console.WriteLine(num.ToString("0.00"));
            Console.WriteLine(num.ToString("0.000"));
            Console.WriteLine(num.ToString("0.0000"));

            Console.WriteLine(52+273);
            Console.WriteLine("52" + 273);
            Console.WriteLine(52 + "273");
            Console.WriteLine("52" + "273");

        }
    }

}
