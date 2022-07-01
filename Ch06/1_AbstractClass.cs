using Ch06.Sub1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06
{
    internal class _1_AbstractClass
    {
        static void Main1(string[] args)
        {
            Car sedan = new Sedan("그랜져", "검정색", 0, 2000);
            Car truck = new Truck("포터", "파란색", 0, 1);

            sedan.SpeedUp(100);
            sedan.SpeedDown(50);
            sedan.Show();

            truck.SpeedUp(200);
            truck.SpeedDown(100);
            truck.Show();

            int a = -3 + (-1);
            Console.WriteLine(a);
        }
    }
}
