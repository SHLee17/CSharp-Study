using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._7
{
    internal class _7_6
    {
        static void Mai1n(string[] args)
        {
            string s = "Hello!, World!";

            Console.WriteLine(s.Length);
            Console.WriteLine(s[0]);
            Console.WriteLine(s.Insert(8, "C#"));
            Console.WriteLine(s.PadLeft(20,'.'));
            Console.WriteLine(s.PadRight(20,'.'));
            Console.WriteLine(s.Substring(5));
            Console.WriteLine(s.Remove(6));
            Console.WriteLine(s.Remove(6,7));
            Console.WriteLine(s.Replace('1','m'));

            Console.WriteLine(s.Substring(8));
            Console.WriteLine(s.Substring(8,5));

            Console.WriteLine(String.Concat("Hi~", s));

            Console.WriteLine(s.ToLower());
            Console.WriteLine(s.ToUpper());
            Console.WriteLine('/' + s.Trim() + '/');


        }
    }
}
