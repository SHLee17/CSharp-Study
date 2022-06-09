using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub4
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
    }
}
