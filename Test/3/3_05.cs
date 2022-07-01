using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3
{
    internal class _3_05
    {

        class Vehicle
        {
            string name;
            int price;

            public Vehicle(string name, int price)
            {
                this.name = name;
                this.price = price;
            }

            public void Show()
            {
                Console.WriteLine("차량명 : " + name);
                Console.WriteLine("가격 : " + price);
                Console.WriteLine();
            }
        }
        class CarFactory
        {
            static CarFactory instance = new CarFactory();
            CarFactory() { }
            public static CarFactory Instance { get { return instance; } }
            public Vehicle MakCar(string name, int price) { return new Vehicle(name, price); }
        }
        static void Main1(string[] args)
        {
            CarFactory factory = CarFactory.Instance;

            Vehicle avante = factory.MakCar("아반테", 2500);
            Vehicle sonata = factory.MakCar("소나타", 3000);

            avante.Show();
            sonata.Show();


        }
    }
}
