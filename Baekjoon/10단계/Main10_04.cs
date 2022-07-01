using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._10단계
{
    internal class Main10_4
    {
        static void Main(string[] args)
        {

            string[] str = Console.ReadLine().Split();

            int a = int.Parse(str[0]), b = int.Parse(str[1]);

            bool[,] chessBoard = new bool[a,b];


            for (int j = 0; j < a; j++)
            {
                string tempLine = "";

                tempLine = Console.ReadLine();

                for (int i = 0; i < tempLine.Length; i++)
                {
                    if ('w' == tempLine[i] || 'W' == tempLine[i])
                        chessBoard[j, i] = true;
                    if ('b' == tempLine[i] || 'B' == tempLine[i])
                        chessBoard[j, i] = false;
                }
            }

            bool temp;
            int count = 0;
            for (int i = 0; i < a; i++)
            {
                temp = i % 2 == 0 ? chessBoard[0, 0] : !chessBoard[0, 0];

                for (int j = 0; j < b; j++)
                {
                    if (i == 0 && j == 0) continue;
                    else if (temp != chessBoard[i, j]) 
                        count++;
                    temp = !temp;
                }

            }

            Console.WriteLine(count);

        }
    }
}
