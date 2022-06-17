using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._9단계
{
    internal class Main9_04
    {
        static int x = 0;
        static int y = 0;
        static int input = 0;

        public Main9_04()
        {
           
        }

        static void Main(string[] args)
        {
            input = int.Parse(Console.ReadLine()) - 1;

            x = 0;
            y = 0;

            Star();
            
        }

        static void Star()
        {
            if (x >= input && y >= input) return;
            if (x == input)
            {
                Console.Write("\n");
                y++;
                x = 0;
            }
            x++; 
            if(y % 2 == 0)
            {
                Console.Write("*");
            }
            else
                Console.Write(" ");

            Star();

        }

    }
}
