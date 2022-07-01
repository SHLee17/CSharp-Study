using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch07
{
    internal class _5_HashSet
    {
        static void Main(string[] args)
        {
            HashSet<int> hs = new HashSet<int>();

            hs.Add(1);
            hs.Add(2);
            hs.Add(3);
            hs.Add(4);
            hs.Add(5);
            hs.Add(2);
            hs.Add(3);

            Console.WriteLine("집합 원소 갯수 : " + hs.Count);

            foreach (int item in hs)
                Console.Write( item +" ");

            Console.WriteLine();

            HashSet<int> set1 = new HashSet<int>() { 1, 2, 3, 4, 5 };
            HashSet<int> set2 = new HashSet<int>() { 2, 3, 5, 6, 7 };

            IEnumerable<int> result1 = set1.Intersect(set2);
            IEnumerable<int> result2 = set1.Union(set2);
            IEnumerable<int> result3 = set1.Except(set2);


            foreach (int item in result1)
                Console.Write(item + " ");
            Console.WriteLine();
            foreach (int item in result2)
                Console.Write(item + " ");
            Console.WriteLine();
            foreach (int item in result3)
                Console.Write(item + " ");
        }


    }
}
