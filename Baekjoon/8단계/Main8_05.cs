using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._8단계
{
    internal class Main8_05
    {

        static void Main(string[] args)
        {

            List<int> nums = new List<int>();

            while (true)
            {
                int a = int.Parse(Console.ReadLine());
                if (a != 0)
                    nums.Add(a);
                else
                    break;
            }

            StringBuilder sb = new StringBuilder();

            foreach (int item in nums)
            {

                bool[] temp = new bool[item + 1];

                for (int i = 2; i <= Math.Sqrt(item * 2); i++)
                {
                    if (temp[i]) continue;
                    for (int j = i * 2; j <= item * 2; j += i)
                        temp[j] = true;
                }

                int count = 0;
                for (int i = item; i <= item * 2; i++)
                {
                    if (!temp[i] && i > 1)
                        count++;
                }
                sb.Append(count + "\n");

            }
            Console.WriteLine(sb);
        }

    }
}
