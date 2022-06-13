using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._7단계
{
    internal class Main7_05
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < range; i++)
            {
                string[] inputs = Console.ReadLine().Split();
                int temp = 0;
                int temp2 = 0;
                int h = int.Parse(inputs[0]);
                int w = int.Parse(inputs[1]);
                int n = int.Parse(inputs[2]);

                temp = h >= n ? h % n : n % h;
                temp2 = h >= n ? h / n : n / h;
                if (n == 1)
                    sb.Append(101);
                else if (temp == 0)
                    temp = h * 100 + temp2;
                else
                    temp = temp * 100 + temp2 + 1;

                sb.AppendLine(temp.ToString());
            }

            Console.WriteLine(sb);
            // 30 50 72  1203
        }
    }
}
