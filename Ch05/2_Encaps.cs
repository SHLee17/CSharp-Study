using Ch05.Sub2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05
{
    internal class _2_Encaps
    {
        /*
         * 2022/06/08
         * p203
         * 캡슐화
         * - 캡슐화는 객체의 내용을 외부에서 참조하지 못하도록 객체의 정보를 은닉하는 특성을 말한다.
         * - 캡슐화를 위한 접근 제한자 public private protected를 제공한다.
         * - 윽닉된 정보의 안전한 제공을 위해 getter와 setter를 제공한다. 프로퍼티
         */
        static void Main1(string[] args)
        {
            Account kb = new Account("국민", "31231-12", "김유신", 100);
            kb.Deposit(4000);
            kb.Withdraw(3000);

            Car sonata = new Car("소나타", "흰색", 0);

            sonata.Name = "EF소나타";
            sonata.Speed = -100;

            Console.WriteLine("sonata 객체 name :" + sonata.Name);

            sonata.SpeedUp(60);
            sonata.Show();
            
        }
    }
}
