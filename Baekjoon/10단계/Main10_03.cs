using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._10단계
{

    
    internal class Main10_03
    {
        class Bulk
        {
            public int w;
            public int h;
            public int rank;
            public List<Bulk> link;
            public Bulk(int w, int h)
            {
                rank = 1;
                this.w = w;
                this.h = h;
                link = new List<Bulk>();
            }
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            List<Bulk> list = new List<Bulk>();

            for (int i = 0; i < a; i++)
            {
                string[] input = Console.ReadLine().Split();

                list.Add(new Bulk(int.Parse(input[0]), int.Parse(input[1])));
            }


            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i].h > list[j].h)
                    {
                        if (list[i].w > list[j].w)
                        {
                            list[j].rank++;
                        }
                        else
                        {
                            list[i].link.Add(list[j]);
                        }
                    }
                }
            }

            Console.WriteLine(list);

        }
    }
}
