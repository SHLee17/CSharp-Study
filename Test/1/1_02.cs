using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1
{
    internal class _1_02
    {
        static void Main1(string[] args)
        {
            int year;
            int birth;
            string name;

            Console.Write("올해 년도 입력 : ");
            year = int.Parse(Console.ReadLine());

            Console.Write("태어난 년도 입력 : ");
            birth = int.Parse(Console.ReadLine());

            Console.Write("이름 입력 : ");
            name = Console.ReadLine();

            Console.WriteLine($"{name}님 안녕하세요\n당신은 올해 만 {year - birth}세 입니다.");
        }
    }
}
