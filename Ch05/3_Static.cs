using Ch05.Sub2;
using Ch05.Sub3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05
{
    class Increment
    {
        public int num1;
        public static int num2;

        public Increment()
        {
            num1++;
            num2++;

            Console.WriteLine($"num1 : {num1}, num2 : {num2}");
        }
        public static void Add()
        {
            //num1++;
            num2++;

            Console.WriteLine("num2 : {0}", num2 );
        }
    }
    internal class _3_Static
    {
        static void Main(string[] args)
        {
            Increment inc1 = new Increment();
            Increment inc2 = new Increment();
            Increment inc3 = new Increment();

            Increment.num2 = 10;
            Increment.Add();


            Car car1 = new Car("현대차", "검은색", 0);
            Car car2 = new Car("기아차", "흰색", 0);

            car1.Show();
            car2.Show();

            Calc c1 = Calc.Instance;

            int r1 = c1.Plus(1, 2);

        }
    }
}
