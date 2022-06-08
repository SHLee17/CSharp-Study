using Ch05.Sub1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05
{
    internal class _1_Class
    {
        static void Main(string[] args)
        {
            Car sonata = new Car();
            sonata.speed = 0;
            sonata.name = "소나타";
            sonata.color = "흰색";


            sonata.SpeedUp(10);
            sonata.SpeedUp(50);
            sonata.SpeedDown(20);
            sonata.Show();

            Car bmw = new Car("BMW", "검은색", 0);

            bmw.SpeedUp(10);
            bmw.SpeedUp(50);
            bmw.SpeedDown(20);
            bmw.Show();

            Account kb = new Account("국민은행", "123-123", "홍길동", 10000);

            kb.Deposit(25000);
            kb.Withdraw(5000);
            kb.Show();

            Account nh = new Account("농협", "3213-123", "김유신", 30000);

            nh.Deposit(70000);
            nh.Withdraw(20000);
            nh.Show();
        }
    }
}
