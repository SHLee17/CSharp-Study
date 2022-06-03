using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch02
{
/*
 * 날짜 : 2022 06 02
 * 이름 : 이동건
 * 내용 : 데이터 형식 반환 실습 교재 p106
 */
    internal class _5_Conversion
    {
        static void Main1(string[] args)
        {
            #region 작은 변수에서 큰변수
            byte num1 = 255;
            short num2 = num1;
            int num3 = num2;

            Console.WriteLine("num1 : {0}", num1);
            Console.WriteLine("num2 : {0}", num2);
            Console.WriteLine("num3 : {0}", num3);
            #endregion

            #region 큰 변수에서 작은 변수

            int var1 = 50000;
            short var2 = (short)var1;
            byte var3 = (byte)var2;

            Console.WriteLine("var1 : {0}", var1);
            Console.WriteLine("var2 : {0}", var2);
            Console.WriteLine("var3 : {0}", var3);
            #endregion

            #region 정수에서 실수

            int a = 1;
            int b = 2;
            int c = 3;

            double d1 = a;
            double d2 = b;
            double d3 = c;

            Console.WriteLine($"d1 : {d1}");
            Console.WriteLine($"d2 : {d2}");
            Console.WriteLine($"d3 : {d3}");


            #endregion

            #region 실수에서 정수
            double n1 = 1.2;
            double n2 = 2.15;
            double n3 = 11.123;

            int rs1 = (int)n1;
            int rs2 = (int)n2;
            int rs3 = (int)n3;

            Console.WriteLine($"rs1 : {rs1}");
            Console.WriteLine($"rs2 : {rs2}");
            Console.WriteLine($"rs3 : {rs3}");
            #endregion

        }
    }
}
