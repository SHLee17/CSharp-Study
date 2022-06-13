using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub1
{
    internal class Truck : Car
    {
        int capacity;
        public Truck(string name, string color, int speed, int capacity) : base(name, color, speed)
        {
            this.capacity = capacity;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("트럭적재량\t: {0}",capacity);
            Console.WriteLine("================================");
        }

        public override void SpeedDown(int speed)
        {
            Console.WriteLine("Truck SpeedDown");
            base.speed -= speed;
        }

        public override void SpeedUp(int speed)
        {
            Console.WriteLine("Truck SpeedUp");
            base.speed += speed;
        }
    }
}
