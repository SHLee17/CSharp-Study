using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._5
{
    internal class _5_3
    {
        static void Main1(string[] args)
        {
            PrintList(CreateList());
        }

        public static void PrintList(List<int> scoreList)
        {
            int total = 0;
            int count = scoreList.Count;

            for (int i = 0; i < count; i++)
            {
                int score = scoreList[i];
                total += score;

                Console.Write(score);

                if(i == count -1)
                    Console.Write(" = ");
                else
                    Console.Write(" + ");
            }
            Console.WriteLine(total);
        }

        public static List<int> CreateList()
        {
            List<int> scoreList = new List<int>();
            Random rand = new Random();

            for (int i = 0; i <= 10; i++)
            {
                int num = rand.Next(41) + 60;
                scoreList.Add(num);
            }

            return scoreList;
        }
    }
}
