﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._10
{
    class Products
    {
        List<Product> list = new List<Product>();

        public void SetProduct(string item, int price)
        {
            Product product = new Product();
            product.SetItem(this, item, price);
        }
        public void ShowList()
        {
            foreach (Product item in list)
                Console.WriteLine("상품 : {0}, 가격 : {1:C} ", item.GetItem(), item.GetPrice());
        }

        class Product
        {
            string item;
            int price;

            public void SetItem(Products outer, string item , int price)
            {
                this.item = item;
                this.price = price;

                outer.list.Add(this);
            }
            public string GetItem() { return item; }
            public int GetPrice() { return price; }
        }
        
    }
    internal class _10_5
    {
        static void Main1(string[] args)
        {
            Products products = new Products();
            products.SetProduct("신발", 30000);
            products.SetProduct("셔츠", 20000);
            products.SetProduct("바지", 15000);

            products.ShowList();
        }
    }
}
