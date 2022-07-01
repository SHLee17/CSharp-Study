using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._9
{
    internal class _9_7
    {
        static void Main1(string[] args)
        {

            DrawPyramid(3);
            DrawPyramid(5);
            DrawPyramid(7);

            void DrawPyramid(int n)
            {
                for (int i = 0; i <= n; i++)
                {
                    for (int j = i; j < n; j++)
                        Console.Write(" ");
                    for (int j = 1; j < i * 2; j++)
                        Console.Write("*");
                    Console.WriteLine();
                }
            }
        }
    }
}
