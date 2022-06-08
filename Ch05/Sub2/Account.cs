using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub2
{
    internal class Account
    {



        string bank;
        string id;
        string name;
        int balance;

        public Account(string bank, string id, string name, int balance)
        {
            this.bank = bank;
            this.id = id;
            this.name = name;
            this.balance = balance;
        }

        public void Deposit(int money) => balance += money;
        public void Withdraw(int money) => balance -= money;
        public void Show()
        {
            Console.WriteLine("================================");
            Console.WriteLine("은행명 \t\t: {0}", bank);
            Console.WriteLine("계좌번호 \t: {0}", id);
            Console.WriteLine("이름 \t\t: {0}", name);
            Console.WriteLine("현재잔액 \t: {0}", balance);
            Console.WriteLine("================================");


        }

    }
}
