using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch09
{
    internal class _2_Lambda
    {
        static void Main1(string[] args)
        {
            Func<string> f1 = () => { return "f1 실행"; };
            Func<int, string> f2 = (x) => { return "f2 x :" + x; };
            Func<int, int, string> f3 = (a, b) => { return $"f3 a : {a} b : {b}"; };

            string r1 = f1();
            string r2 = f2(3);
            string r3 = f3(3, 4);

            Console.WriteLine("r1 : " + r1);
            Console.WriteLine("r2 : " + r2);
            Console.WriteLine("r3 : " + r3);

            Action a1 = () => Console.WriteLine("Hello World");
            Action<int> a2 = (a) => Console.WriteLine("a2 : " + a);
            Action<int,int> a3 = (a,b) => Console.WriteLine($"a3 : a : {a} b : {b}");
            a1();
            a2(5);
            a3(6, 7);


            List<int> dataSet = new List<int>();

            for (int i = 1; i < 10; i++)
                dataSet.Add(i);

            dataSet.ForEach(n => Console.WriteLine(n));
        }
    }
}
