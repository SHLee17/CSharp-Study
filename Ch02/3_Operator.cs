﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022 06 02
 * 이름 : 이동건
 * 내용 : 연산자 실습하기 교재 p90
 * 
 * 연산자
 * -변수에 저장된 데이터의 처리를 위해 연산자를 사용
 * -연산자는 크게 산술, 증가감소, 복합대입, 비교, 논리 연산자 등이 있다.
 */
namespace Ch02
{
    internal class _3_Operator
    {
        static void Main1(string[] args)
        {
            #region 산술 연산자
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int num4 = 4;

            int r1 = num1 + num2;
            int r2 = num1 + num2;
            int r3 = num2 * num3;
            int r4 = num4 / num2;
            int r5 = num4 % num3;

            Console.WriteLine("r1 : " + r1);
            Console.WriteLine("r2 : " + r2);
            Console.WriteLine("r3 : " + r3);
            Console.WriteLine("r4 : " + r4);
            Console.WriteLine("r5 : " + r5 +"\n");
            #endregion

            #region 증감, 감소 연산자
            int num = 0;
            num++;
            ++num;

            Console.WriteLine($"num : {num}"); // 문자열 보간 출력

            num--;
            --num;
            Console.WriteLine($"num : {num} \n");

            #endregion

            #region 복합대입 연산자

            int n1 = 1, n2 = 2, n3 = 3, n4 = 4;

            n1 += 1;
            n2 -= 2;
            n3 *= 3;
            n4 /= 4;

            Console.WriteLine($"n1 : {n1}");
            Console.WriteLine($"n2 : {n2}");
            Console.WriteLine($"n3 : {n3}");
            Console.WriteLine($"n4 : {n4}\n");


            #endregion

            #region 비교 연산자

            int var1 = 1;
            int var2 = 2;

            bool rs1 = var1 > var2;
            bool rs2 = var1 < var2;
            bool rs3 = var1 >= var2;
            bool rs4 = var1 <= var2;
            bool rs5 = var1 == var2;
            bool rs6 = var1 != var2;

            Console.WriteLine($"rs1 : {rs1}");
            Console.WriteLine($"rs2 : {rs2}");
            Console.WriteLine($"rs3 : {rs3}");
            Console.WriteLine($"rs4 : {rs4}");
            Console.WriteLine($"rs5 : {rs5}");
            Console.WriteLine($"rs6 : {rs6}\n");


            #endregion

            #region 논리 연산자
            int val1 = 1;
            int val2 = 2;

 
            bool res1 =  val1 > 1 && val2 > 2;
            bool res2 = val1 > 0 && val2 > 1;
            bool res3 = val1 > 1 || val2 > 2;
            bool res4 = val1 > 0 || val2 > 2;
            bool res5 = !(val1 > val2);

            Console.WriteLine($"res1 : {res1}");
            Console.WriteLine($"res2 : {res2}");
            Console.WriteLine($"res3 : {res3}");
            Console.WriteLine($"res4 : {res4}");
            Console.WriteLine($"res5 : {res5}\n");
            #endregion

            #region 조건 연산자
            int a = 1;

            string result = a > 1 ? "a는 1보다 크다" : "a는 1보다 크지 않다.";

            Console.WriteLine($"result : {result}\n");
            #endregion
        }
    }
}