using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P99
    {
        static void Main1(string[] args)
        {
            Console.WriteLine((273).GetType());
            Console.WriteLine((522731033265).GetType());
            Console.WriteLine((52.273f).GetType());
            Console.WriteLine((52.27).GetType());
            Console.WriteLine(('글').GetType());
            Console.WriteLine(("문자열").GetType());
        }
    }

}
