using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._9단계
{
    internal class Main9_04
    {

        static char[,] map = new char[3000, 3000];

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    map[i, j] = ' ';
                }
            }

            FillStar(n, 0, 0);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sb.Append(map[i, j]);
                }
                sb.Append("\n");
            }

            Console.WriteLine(sb);

        }


        //별을 채웁니다.
        static void FillStar(int n, int y, int x)
        {
            if (n == 1)
            {
                map[y, x] = '*';
                Console.Write($"({n},{y},{x})");
                return;
            }
            else 
            Console.Write($"(f{n},{y},{x})");
            int div = n / 3;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == 1 && j == 1)
                    {
                        Console.Write($"(빈{n},{y},{x})");
                        continue;
                    }
                    FillStar(div, y + (div * i), x + (div * j));
                }
                Console.WriteLine();
            }
            return;
        }
    }
}
