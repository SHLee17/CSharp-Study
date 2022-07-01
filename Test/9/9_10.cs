using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._9
{
    internal class _9_10
    {
        static void Main1(string[] args)
        {
            int[] a = { 1, 2, 3 };
            double[] d = { 0.1, 0.2, 0.3 };
            string[] s = { "apple", "banana", "cherry" };

            PrintArray(a);
            PrintArray(d);
            PrintArray(s);
        }
        static void PrintArray<T> (T[]arr)
        {
            foreach (T item in arr)
                Console.Write("{0,8}", item);
            Console.WriteLine();
        }
    }
}
