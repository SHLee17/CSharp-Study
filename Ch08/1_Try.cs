using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch08
{
    internal class _1_Try
    {
        class Apple
        {
            public void Show() => Console.WriteLine("Apple Class");

        }
        static void Main1(string[] args)
        {
            int num1 = 1;
            int num2 = 0;

            int rs1 = num1 + num2;
            int rs2 = num1 - num2;
            int rs3 = num1 * num2;
            int rs4 = 0;
            try
            {
                rs4 = num1 / num2;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            CW(nameof(rs1),rs1);
            CW(nameof(rs2),rs2);
            CW(nameof(rs3),rs3);
            CW(nameof(rs4),rs4);

            int[] arr = { 1, 2, 3, 4, 5 };

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Apple a1 = new Apple();
            Apple a2 = null;

            try
            {
                a1.Show();
                a2.Show();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            try
            {
                Console.WriteLine("try...");
            }
            catch (Exception e)
            {
                Console.WriteLine("catch...");
            }
            finally
            {
                Console.WriteLine("finally...");
            }
            Console.WriteLine("프로그램 종료");

        }
        static void CW(string b, int a)
        {
            Console.WriteLine( $"{b} : {a} ");
        }

    }
}
