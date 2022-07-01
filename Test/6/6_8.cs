using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._6
{
    internal class _6_8
    {
        static void Main1(string[] args)
        {
            LinkedList<string> lkList = new LinkedList<string>();

            lkList.AddFirst("김유신");
            lkList.AddFirst("김춘추");
            lkList.AddFirst("장보고");
            lkList.AddLast("강감찬");
            lkList.AddLast("이순신");
            lkList.AddLast("정약용");

            Console.WriteLine(String.Join(", ", lkList));

            LinkedListNode<string> findNode = lkList.Find("이순신");
            LinkedListNode<string> addnode1 = new LinkedListNode<string>("이성계");
            LinkedListNode<string> addnode2 = new LinkedListNode<string>("임꺽정");

            lkList.AddBefore(findNode, addnode1);
            lkList.AddAfter(findNode, addnode2);

            Console.WriteLine(string.Join(", ",lkList));
            Console.WriteLine();


            SortedList<int, string> sList = new SortedList<int, string>();

            sList.Add(101, "한국");
            sList.Add(104, "중국");
            sList.Add(106, "대만");
            sList.Add(103, "일본");
            sList.Add(105, "호주");
            sList.Add(102, "미국");

            Console.WriteLine(String.Join(", ", sList));
            for (int i = 0; i < sList.Count; i++)
                Console.WriteLine("sList K:{0}, V:{1}", sList.Keys[i], sList.Values[i]);
        }
    }
}
