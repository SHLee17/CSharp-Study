using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch07.Sub1;

// - 배열과 유사한 동적 선형 자료구조
// - List는 ArrayList를 일반화 시킨 자료구조 ArrayList보다 더 나은 성능
namespace Ch07
{
    internal class _3_ArrayList
    {
        static void Main1(string[] args)
        {

            ArrayList arryList = new ArrayList();

            arryList.Add(1);
            arryList.Add(2);
            arryList.Add(3);
            arryList.Add(4);
            arryList.Add(5);

            foreach (int item in arryList)
                Console.Write(item + " ");

            Console.WriteLine();

            arryList.Insert(1, 6);

            arryList.Remove(6);
            arryList.RemoveAt(0);

            foreach (int item in arryList)
                Console.Write(item + " ");

            Console.WriteLine();


            ArrayList arrayList1 = new ArrayList();

            arrayList1.Add(100);
            arrayList1.Add(0.123);
            arrayList1.Add(true);
            arrayList1.Add('A');
            arrayList1.Add("apple");

            for (int i = 0; i < arrayList1.Count; i++)
                Console.Write(arrayList1[i] + " ");

            Console.WriteLine();

            List<int> list = new List<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            foreach (int item in list)
                Console.Write(item + " ");

            Console.WriteLine();

            List<string> list1 = new List<string>();

            list1.Add("김유신");
            list1.Add("김춘추");
            list1.Add("장보고");
            list1.Add("강감찬");
            list1.Add("이순신");

            list1.ForEach(x => Console.Write(x + " ") );

            Console.WriteLine();

            List<Apple> list2 = new List<Apple>();
            list2.Add(new Apple("한국", 3000));
            list2.Add(new Apple("미국", 2000));
            list2.Add(new Apple("일본", 1000));
            list2.ForEach(x => x.Show()) ;

        }
    }
}
