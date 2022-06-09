using Ch05.Sub4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * p331
 * 상속
 * - 기존 클래스의 속성과 기능을 그대로 파생 클래스로 물려줘 클래스를 확장하는 문법
 * - 공통적인 냉용을 부모클래스에 두고 자식 클래스에서 프로그래밍을 수행
 * 
 */
namespace Ch05
{
    class Parent
    {
        int num1;
        int num2;

        public Parent(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
            Console.WriteLine("부모 생성자");
        }
        public int Plus() { return num1 + num2; }

    }
    class Child :Parent
    {
        int num3;
        int num4;

        public Child(int num1, int num2, int num3, int num4) : base(num1, num2)
        {
            this.num3 = num3;
            this.num4 = num4;
            Console.WriteLine("자식 생성자");
        }

        public int Minus() { return num3 - num4; }

        //public Child(int num1, int num2) : base(num1, num2)
        //{

        //}
    }
    internal class _4_Inheritance
    {
        static void Main1(string[] args)
        {
            Child c1 = new Child(1, 2, 3, 4);
            Child c2 = new Child(10, 20, 30, 40);

            Console.WriteLine("plus c1\t\t: {0}" ,c1.Plus());
            Console.WriteLine("minus c1\t: {0}", c1.Minus());

            Sedan sedan = new Sedan("그렌져", "검적색", 0, 2000);
            Truck truck = new Truck("봉고", "파란색", 0, 1);

            sedan.SpeedUp(40);
            sedan.Show();
            truck.SpeedUp(70);
            truck.Show();

            StockAccount kb = new StockAccount("KB", "100 - 1", "ABC", 100, "삼성전자", 0, 0);
            kb.Deposit(100000);
            kb.Buy(10, 7000);
            kb.Sell(5, 7500);
            kb.Show();

        }

    }
}
