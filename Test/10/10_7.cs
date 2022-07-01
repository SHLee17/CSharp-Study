using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._10
{
    interface IRunnable
    {
        void Run();
    }
    interface IFlyable
    {
        void Fly();
    }
    class FlyingCar : IRunnable, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Car Fly!");
        }

        public void Run()
        {
            Console.WriteLine("Car Run!");
        }
    }
    internal class _10_7
    {
        static void Main1(string[] args)
        {
            FlyingCar car = new FlyingCar();
            car.Run();
            car.Fly();

            IRunnable runnable = car as IRunnable;
            IFlyable flyable = car as IFlyable;

            runnable.Run();
            flyable.Fly();
        }
    }
}
