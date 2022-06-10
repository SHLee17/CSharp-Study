using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1
{
    internal class _2_03
    {
        static void Main1(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < 10; i++)
                Console.Write(arr[i] + ", ");
            Console.Write("\n");

            for (int i = 0; i < 5; i++)
            {
                int temp = arr[i];
                arr[i] = arr[9 - i];
                arr[9 - i] = temp;
            }
            foreach (int item in arr)
                Console.Write(item + ", ");
        }
    }
}
