using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._9단계
{
    internal class Main9_05
    {
        static StringBuilder sb = new StringBuilder();
        static int cnt = 0;

        static void Main(string[] args)
        {
            string temp = Console.ReadLine();

            int height = int.Parse(temp);


            Hanoi(height, 1, 2, 3);

            sb.Insert(0, $"{cnt}\n");

            Console.WriteLine(sb);
        }

        public static void Hanoi(int h, int start, int half, int goal)
        {
            if (h == 1)
            {
                Console.WriteLine(start + " " +goal);
                sb.Append($"{start} {goal}\n");
                cnt++;
            }
            else
            {
                Hanoi(h - 1, start, goal, half);

                Console.WriteLine(start + " " + goal);
                sb.Append($"{start} {goal}\n");
                cnt++;

                Hanoi(h - 1, half, start, goal);
            }

        }

    }
}

