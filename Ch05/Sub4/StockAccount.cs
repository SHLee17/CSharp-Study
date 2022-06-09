using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch05.Sub4;


namespace Ch05.Sub4
{
    internal class StockAccount :Account
    {
        string stock;
        int amount;
        int price;

        public StockAccount(string bank, string id, string name, int balance, 
                            string stock, int amount, int price) : base(bank, id, name, balance)
        {
            this.stock = stock;
            this.amount = amount;
            this.price = price;
        }

       public void Sell(int amount, int price)
        {
            this.amount -= amount;
            base.balance += amount * price;
        }
        public void Buy(int amount, int price) 
        {
            this.amount += amount;
            base.balance -= amount * price;

        }

        public void Show()
        {
            base.Show();

            Console.WriteLine("Stock\t\t: {0}", stock);
            Console.WriteLine("Amount\t\t: {0}", amount);
            Console.WriteLine("Price\t\t: {0}", price);
            Console.WriteLine("================================");

        }
    }
}
