using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 
 * 2022/06/14 p404
 *  p 404
 *  -간단하게 객체를 만들때 사용하는 구조 형식
 *  -클래스와 동일하지만 몇가지 제한
*/ 
namespace Ch06
{
    struct MyPoint
    {
        public int x;
        public int y;

        public MyPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return string.Format($"x : {x}, y : {y}");
        }
    }


    internal class _3_Sturcture
    {
        static void Main1(string[] args)
        {
            MyPoint p1;
            p1.x = 10;
            p1.y = 20;

            Console.WriteLine("p1 : " +p1.ToString());

            MyPoint p2 = new MyPoint(20, 30);

            Console.WriteLine("p2 : " + p2.ToString());

        }
    }
}
