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
            List<List<int>> list = new List<List<int>>();
            for (int i = 0; i < range; i++)
            {
                List<int> tempList = new List<int>();

                string[] str = Console.ReadLine().Split();
                foreach (string item in str)
                    tempList.Add(int.Parse(item));

                list.Add(tempList);
            }

            for (int i = 0; i < range; i++)
            {
                foreach (int item in list[i])
                {
                    Console.Write(item);
                }
                Console.WriteLine();
            }
            



            

        }

    }
}
