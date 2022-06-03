using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P83
    {
        static void Main1(string[] args)
        {
            uint unsignedInt = 414783647;
            ulong unsignedLong = 11223372036854775808;

            Console.WriteLine(unsignedInt);
            Console.WriteLine(unsignedLong);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);
        }
    }
}
