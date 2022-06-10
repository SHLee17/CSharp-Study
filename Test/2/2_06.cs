using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1
{
    internal class _2_06
    {
        static void Main1(string[] args)
        {
            Intro();
            int a = Intro('a');
            int b = Intro('b');

            int output = Add(a, b);
            Result(output);

        }

        public static void  Intro()
        {
            Console.WriteLine("******* START *******");
            Console.WriteLine("두개의 정수를 입력");
        }
        public static int Intro(char name)
        {
            Console.Write("변수 " + name + "값 입력 : ");
            int value = int.Parse(Console.ReadLine());
            return value;
        }
        public static void Result(int value)
        {
            Console.WriteLine("덧셈 결과 : " +value);
            Console.WriteLine("******* END *******");
        }
        public static int Add(int x , int y) { return x + y; }


    }
}
