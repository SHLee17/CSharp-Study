using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch02
{
/*
 * 날짜 : 2022 06 02
 * 이름 : 이동건
 * 내용 : 입출력 실습하기 교재 p104
 */
    internal class _4_InputTest
    {
        static void Main1(string[] args)
        {
            Console.Write("이름 : ");
            string name = Console.ReadLine();
            Console.Write("나이 : ");
            string age = Console.ReadLine();
            Console.Write("주소 : ");
            string address = Console.ReadLine();

            Console.WriteLine("=====================");
            Console.WriteLine($"이름 : {name} ");
            Console.WriteLine($"나이 : {age}");
            Console.WriteLine($"주소 : {address}");
        }
    }
}
