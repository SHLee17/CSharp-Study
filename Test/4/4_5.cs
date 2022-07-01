﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._4
{
    

    internal class _4_5
    {
     
        class TV
        {
            public string Show()
            {
                return "TV 입니다.";
            }
        }
        class Computer
        {
            public string Show()
            {
                return "Computer 입니다.";
            }
        }
        class Product<T1, T2>
        {
            T1 item;
            T2 info;

            public Product(T1 item, T2 info)
            {
                this.item = item;
                this.info = info;
            }

            public T1 Item { get => item; set => item = value; }
            public T2 Info { get => info; set => info = value; }
        }
        
     
        static void Main1(string[] args)
        {
            TV tv = new TV();
            Computer com = new Computer();

            Product<TV, int> item1 = new Product<TV, int>(tv, 55);
            Console.WriteLine(item1.Item.Show());
            Console.WriteLine("TV 인치 : " + item1.Info);
            Console.WriteLine();

            Product<Computer, string> item2 = new Product<Computer, string>(com, "Apple");
            Console.WriteLine(item2.Item.Show());
            Console.WriteLine("Com 제조사 : " + item2.Info);
            Console.WriteLine();

        }
    }
}
