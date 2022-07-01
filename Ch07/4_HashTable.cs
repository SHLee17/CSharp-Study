using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch07.Sub1;

namespace Ch07
{
    internal class _4_HashTable
    {
        static void Main1(string[] args)
        {
            Hashtable ht = new Hashtable();

            // k v
            ht['A'] = "Apple";
            ht['B'] = "Banana";
            ht['C'] = "Cherry";

            Console.WriteLine("Tabel['A'] : " + ht['A']);
            Console.WriteLine("Tabel['B'] : " + ht['B']);
            Console.WriteLine("Tabel['C'] : " + ht['C']);


            foreach (char item in ht.Keys)
                Console.WriteLine(ht[item]);
            
            Console.WriteLine();

            Dictionary<char, string> dict = new Dictionary<char, string>();

            dict.Add('A', "Apple");
            dict.Add('B', "Banana");
            dict.Add('C', "Cherry");
            
            foreach (string item in dict.Values)
                Console.WriteLine(item);
            
            Console.WriteLine();

            Dictionary<int, string> people = new Dictionary<int, string>();

            people.Add(101, "김유신");
            people.Add(102, "김춘추");
            people.Add(103, "장보고");
            people.Add(104, "강감찬");
            people.Add(105, "이순신");

            foreach (KeyValuePair<int,string> item in people)
                Console.WriteLine(item.Key +" : " + item.Value);

            Console.WriteLine();

            Dictionary<int, Apple> d1 = new Dictionary<int, Apple>();
            Dictionary<int, Apple> d2 = new Dictionary<int, Apple>();
            Dictionary<int, Apple> d3 = new Dictionary<int, Apple>();

            d1.Add(101, new Apple("한국", 3000));
            d1.Add(102, new Apple("미국", 2000));
            d1.Add(103, new Apple("일본", 1000));

            d2.Add(201, new Apple("중국", 3000));
            d2.Add(202, new Apple("대만", 2000));
            d2.Add(203, new Apple("홍콩", 1000));

            d3.Add(301, new Apple("호주", 3000));
            d3.Add(302, new Apple("영국", 2000));
            d3.Add(303, new Apple("인도", 1000));

            List<Dictionary<int, Apple>> apples = new List<Dictionary<int, Apple>>();

            apples.Add(d1);
            apples.Add(d2);
            apples.Add(d3);
            apples[0][101].Show();
            Console.WriteLine();
            apples[0][102].Show();
            Console.WriteLine();
            apples[1][201].Show();
            Console.WriteLine();
            apples[2][303].Show();
            Console.WriteLine();

        }
    }
}
