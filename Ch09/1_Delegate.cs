using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch09
{
    public delegate int MyDelegate(int a, int b);
    public delegate int SumDelegate(int[] arr);
    internal class _1_Delegate
    {
        static void Main1(string[] args)
        {
            MyDelegate md = new MyDelegate(plus);
            MyDelegate md2 = new MyDelegate(minus);


            int r1 = md(1, 2);
            Console.WriteLine("r1 : " + r1);

            int r2 = md2(1, 2);

            Console.WriteLine("r1 : " + r2);

            int[] arr = { 1,2,3,4,5,6,7,8,9,10 };

            int rs1 = Sum(arr, OddSum);
            int rs2 = Sum(arr, EvenSum);

            Console.WriteLine("OddSum : " + rs1);
            Console.WriteLine("EveneSum : " + rs2);

            var mdelegate = delegate (int a, int b)
            {
                return a * b;
            };

            int rs3  = mdelegate(2, 3);

            Console.WriteLine("multiplication : " + rs2);

            List<int> dataSet = new List<int>();

            for (int i = 0; i < 10; i++)
                dataSet.Add(i);

            dataSet.ForEach(delegate (int n) { Console.Write(n +" "); });


        }
        static int plus(int a , int b) { return a + b; }
        static int minus(int a, int b) { return a - b; }

        static int OddSum(int[] arr)
        {
            int sum = 0;

            foreach (int item in arr)
            {
                if(item % 2 == 1)
                {
                    sum += item;
                }
            }
            return sum;
        }
        static int EvenSum(int[] arr)
        {
            int sum = 0;

            foreach (int item in arr)
            {
                if (item % 2 == 0)
                {
                    sum += item;
                }
            }
            return sum;
        }

        static int Sum(int[] arr, SumDelegate sumDelegate)
        {
            return sumDelegate(arr);
        }
    }
}
