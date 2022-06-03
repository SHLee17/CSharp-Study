using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P106
    {
        static void Main1(string[] args)
        {
            long longNum = 2147483647L + 2147483647L;
            int intNum = (int)longNum;
            Console.WriteLine(intNum);

            var a = (int)10.0;
            var b = (float)10;
            var c = (double)10;
        }
    }

}
