using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._7
{
    internal class _7_9
    {
        enum Sizes { Short, Tall, Grande, Venti};
        enum Coffes {Short = 3300, Tall = 3800, Grande = 4300, Venti = 4800 , End}
        static void Main1(string[] args)
        {
            Console.WriteLine("커피 가격표");

            for (int i = 0; i < 4; i++)
            {
                if(i == (int)Sizes.Short)
                {
                    Console.WriteLine("{0,10} : {1:C}", (Sizes)i, (int)Coffes.Short );
                }
                else if (i == (int)Sizes.Tall)
                {
                    Console.WriteLine("{0,10} : {1:C}", (Sizes)i, (int)Coffes.Tall);
                }
                if (i == (int)Sizes.Grande)
                {
                    Console.WriteLine("{0,10} : {1:C}", (Sizes)i, (int)Coffes.Grande);
                }
                if (i == (int)Sizes.Venti)
                {
                    Console.WriteLine("{0,10} : {1:C}", (Sizes)i, (int)Coffes.Venti);
                }
            }

        }
    }
}
