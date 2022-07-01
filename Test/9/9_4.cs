using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._9
{
    internal class _9_4
    {
        static void Main1(string[] args)
        {
            int[] values = { 3, 5, 2, 7, 1 };
            PrintArray(values);

            for (int i = 4; i >0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (values[j] > values[j + 1])
                    {
                        int temp = values[j];
                        values[j] = values[j+1];
                        values[j+1] = temp;
                    }
                }
                PrintArray(values);
            }
        }
        static void PrintArray(int[] arr)
        {
            foreach (int item in arr)
                Console.Write("{0,10}",item);

            Console.WriteLine();
        }
    }
}
