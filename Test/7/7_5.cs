using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._7
{
    internal class _7_5
    {
        static void Main1(string[] args)
        {
            int first = 10;
            int second = 20;
            bool b = false;

            b = (first == second);
            Console.WriteLine("{0} == {1} : {2}", first, second, b);

            b = (first < second);
            Console.WriteLine("{0} < {1} : {2}", first, second, b);

            b = (first >= second);
            Console.WriteLine("{0} >= {1} : {2}", first, second, b);
            b = (first != second);
            Console.WriteLine("{0} != {1} : {2}", first, second, b);
            b = (first == second) || (first > 5);
            Console.WriteLine("{0} == {1} || {0} > 5 : {2}", first, second, b);
            b = (first == second) && (first > 5);
            Console.WriteLine("{0} == {1} && {0} > 5 : {2}", first, second, b);

            b = true ^ false;

            Console.WriteLine("{0} ^ {1} : {2}", true, false, b) ;

        }
    }
}
