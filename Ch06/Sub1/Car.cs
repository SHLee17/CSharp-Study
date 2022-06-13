using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub1
{
    abstract class Car
    {

        #region 속성(필드)
        string name;
        string color;
        protected int speed;

        static int count;

        
        public Car(string name, string color, int speed)
        {
            this.name = name;
            this.color = color;
            this.speed = speed;
        }
        #endregion

        #region 기능(메서드)
        public abstract void SpeedUp(int speed);
        public abstract void SpeedDown(int speed);
        public virtual void Show() 
        {
            Console.WriteLine("================================");
            Console.WriteLine("차량명\t\t: {0}", name);
            Console.WriteLine("차량색\t\t: {0}", color);
            Console.WriteLine("차량속도\t: {0}", speed);
            Console.WriteLine("차량수\t\t: {0}", count);

        }
        #endregion

    }
}
