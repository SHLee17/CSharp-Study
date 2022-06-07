using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03
{
    // 157p
    internal class _3_For
    {
        static void Main1(string[] args)
        {
            int sum = 0;

            #region for문
            for (int i = 0; i < 5; i++)
                Console.WriteLine("{0}회 반복...", i);

            #endregion

            #region 1부터 10까지 합
            for (int i = 1; i <= 10; i++)
                sum += i;

            Console.WriteLine("1부터 10까지 합 :" + sum);
            #endregion

            #region 1부터 10까지 짝수합
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                    sum += i;
            }
            Console.WriteLine("1부터 10까지 짝수합 :" + sum);


            #endregion

            #region 중첩 for문
            for (int a = 0; a <= 3; a++)
            {
                Console.WriteLine("a : " + a);
                for (int b = 0; b <= 4; b++)
                    Console.WriteLine("a : " + b);
            }
            #endregion

            #region 구구단

            for (int i = 2; i < 10; i++)
            {
                Console.WriteLine($"{0}단 시작", i);
                for (int j = 1; j < 10; j++)
                    Console.WriteLine($"{i} * {j} = {i*j}");
            }

            #endregion

            #region 별 삼각형
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("★");

                Console.WriteLine();
            }

            for (int i = 0; i <= 10; i++)
            {
                for (int j = 10 - i; j > 0 ; j--)
                    Console.Write("★");

                Console.WriteLine();
            }
            #endregion
        }
    }
}
