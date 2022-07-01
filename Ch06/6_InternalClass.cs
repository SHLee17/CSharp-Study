using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06
{
    internal class _6_InternalClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PI : " + Math.Sqrt(9));
            Console.WriteLine("제곱근 : " + Math.Sqrt(16));
            Console.WriteLine("제곱근 : " + Math.Abs(-5));
            Console.WriteLine("절대값 : " + Math.Ceiling(1.2));
            Console.WriteLine("올림값 : " + Math.Ceiling(1.8));
            Console.WriteLine("올림값 : " + Math.Floor(1.2));
            Console.WriteLine("내림값 : " + Math.Floor(1.8));
            Console.WriteLine("반올림 : " + Math.Round(1.2));
            Console.WriteLine("반올림 : " + Math.Round(1.8));
            Console.WriteLine();

            Random rand = new Random();
            int rand1 = rand.Next();
            Console.WriteLine("rand1 : " + rand1);

            int rand2 = rand.Next(10);
            Console.WriteLine("rand2 : " + rand2);
            
            int rand3 = rand.Next(1, 10);
            Console.WriteLine("rand3 : " + rand3);

            double rand4 = rand.NextDouble();
            Console.WriteLine("rand4 : " + rand4);

            double rand5 = rand4 * 10;
            Console.WriteLine("rand5 : " + rand5);

            double rand6 = Math.Ceiling(rand5);
            Console.WriteLine("rand6 : " + rand6);

            DateTime now = DateTime.Now;
            Console.WriteLine("Now : " + now);

            Console.WriteLine("년 : " +now.Year);
            Console.WriteLine("월 : " + now.Month);
            Console.WriteLine("년 : " + now.Year);
            Console.WriteLine("시간 : " + now.Hour);
            Console.WriteLine("분 : " + now.Minute);

            string result = now.ToString("yyyy-MM-dd");
            Console.WriteLine("result1 : " + result);

            string result2 = now.ToString("yy-MM-dd hh:mm:ss");
            Console.WriteLine("result1 : " + result2);


        }



    }
}
