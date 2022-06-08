using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub2
{
    internal class Car
    {

        #region 속성(필드)
        private string name;
        public string color;
        private int speed;

        static int count;

        public string Name { get => name; set => name = value; }
        public int Speed { get => speed; 
            set 
            { 
                if( value < 0)
                {
                    Console.WriteLine("0보다 작을 수 없습니다.");

                    speed = 0;
                }
                else
                speed = value; 
            } }

        public Car(string name = "", string color = "", int speed = 0)
        {
            this.Name = name;
            this.color = color;
            this.Speed = speed;
            count++;
        }
        #endregion

        #region 기능(메서드)
        public void SpeedUp(int speed) => this.Speed += speed;
        public void SpeedDown(int speed) => this.Speed -= speed;
        public void Show() 
        {
            Console.WriteLine("================================");
            Console.WriteLine("차량명\t\t: {0}",Name);
            Console.WriteLine("차량색\t\t: {0}", color);
            Console.WriteLine("차량속도\t: {0}", Speed);
            Console.WriteLine("차량수\t: {0}", count);

            Console.WriteLine("================================");

        }
        #endregion

        ~Car()
        {
            Console.WriteLine("Car 소멸자");
        }
    }
}
