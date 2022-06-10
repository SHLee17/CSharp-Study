using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._7단계
{
    internal class Main7_03
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int f = 1, b = 1, seachCount = 1;
            int f1 = 1, b1 = -1;
            int temp = 0;
            while (true)
            {
                
                if (f == 1)
                {
                    b++;
                    temp = b;
                    input--;
                }
                else if (b == 1)
                {
                    f++;
                    temp = f;
                    input--;
                }
                for (int i = 1; i < temp; i++)
                    {
                    if (0 == input) break;
                        f += f1;
                        b += b1;
                        input--;
                    }
                f1 *= -1;
                b1 *= -1;

                if (0 == input) break;

            }

            Console.WriteLine("{0}/{1}", f, b);
        }

    }
}
