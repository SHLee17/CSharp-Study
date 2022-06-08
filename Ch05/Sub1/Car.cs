using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub1
{
    internal class Car
    {

        #region 속성(필드)
        public string name;
        public string color;
        public int speed;


        public Car(string name = "", string color = "", int speed = 0)
        {
            this.name = name;
            this.color = color;
            this.speed = speed;
        }
        #endregion

        #region 기능(메서드)
        public void SpeedUp(int speed) => this.speed += speed;
        public void SpeedDown(int speed) => this.speed -= speed;
        public void Show() 
        {
            Console.WriteLine("================================");
            Console.WriteLine("차량명\t\t: {0}",name);
            Console.WriteLine("차량색\t\t: {0}", color);
            Console.WriteLine("차량속도\t: {0}", speed);
            Console.WriteLine("================================");

        }
        #endregion
    }
}
