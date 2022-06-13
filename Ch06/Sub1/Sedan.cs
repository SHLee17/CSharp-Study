using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub1
{
    internal class Sedan : Car
    {

        int cc;

        public Sedan(string name, string color, int speed, int cc) : base(name, color, speed)
        {
            this.cc = cc;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("차량배기량\t: {0}", cc);
            Console.WriteLine("================================");

        }

        public override void SpeedDown(int speed)
        {
            Console.WriteLine("Sedan SpeedDown");
            base.speed -= speed;
        }

        public override void SpeedUp(int speed)
        {
            Console.WriteLine("Sedan SpeedUp");
            base.speed += speed;
        }
    }
}
