using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._2단계
{
    internal class Main4_07
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());

            for (int i = 0; i < range; i++)
            {
                string[] input = Console.ReadLine().Split();

                int count = int.Parse(input[0]);
                //int[] nums = new int[count];

                double avrgScore = 0;
                for (int j = 1; j < count + 1; j++)
                    avrgScore += double.Parse(input[j]);

                avrgScore = avrgScore / count;

                int avrgCount = 0;
                for (int j = 1; j < count + 1; j++)
                {
                    if (avrgScore < int.Parse(input[j]))
                        avrgCount++;
                }

                double avrg = (double)avrgCount / count * 100;

                Console.WriteLine("{0:#0.000%}", avrg);
                //nums[i] = avrg;
            }

            //foreach  (double item in nums)
            //    Console.WriteLine(Math.Round(item,3));
        }

    }
}
