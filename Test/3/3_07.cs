using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3
{

    class Customer
    {
        int id;
        string name;
        protected string grade;
        protected double point;
        protected double pointRatio;

        public Customer(int id, string name)
        {
            this.id = id;
            this.name = name;
            grade = "SILVER";
            point = 100;
            pointRatio = 0.01;
        }

        public virtual int CalcPrice(int price)
        {
            point += price * pointRatio;
            return price;
        }

        public void ShoInfo()
        {
            Console.WriteLine("=====================");
            Console.WriteLine("고객번호 : " + id);
            Console.WriteLine("고객이름 : " + name);
            Console.WriteLine("고객등급 : " + grade);
            Console.WriteLine("현재 포인트 : " + point);
            Console.WriteLine("포인트 적립율 : " + pointRatio);
            Console.WriteLine("=====================");
        }
    }
    class VipCusomer : Customer
    {
        double saleRatio;

        public VipCusomer(int id, string name) : base(id, name)
        {
            grade = "VIP";
            point = 1000;
            pointRatio = 0.05;
            saleRatio = 0.1;
        }

        public override int CalcPrice(int price)
        {
            point += price * pointRatio;
            return price - (int)(price * saleRatio);
        }

    }
    internal class _3_07
    {

        static void Main1(string[] args)
        {
            Customer kim = new Customer(1001, "김춘추");
            Customer lee = new VipCusomer(1002, "이순신");

            Console.WriteLine("김춘추님이 지불할 금액 : " + kim.CalcPrice(10000) );
            Console.WriteLine("이순신님이 지불할 금액 : " + lee.CalcPrice(10000));

            kim.ShoInfo();
            lee.ShoInfo();

        }
    }
}
