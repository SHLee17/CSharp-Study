using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03
{
    // p167
    internal class _4_While
    {
        static void Main(string[] args)
        {
            #region 1부터 10까지 합
            int sum = 0;
            int k = 1;

            while (k <= 10)
            {
                sum += k;
                k++;
            }
            Console.WriteLine("1부터 10까지 합 {0}", sum);
            #endregion

            #region do ~ while
            int total = 0;
            int i = 1;
            // 최초 한 번은 무조건 반복 실행하는 반복문
            do
            {
                if (i % 2 == 0)
                    total += i;

                i++;
            }
            while (i <= 10);

            Console.WriteLine("1 ~ 10까지 짝수의 합 " + total);
            #endregion

            #region break
            int num = 1;

            while (true)
            {
                if(num % 5 == 0 && num % 7 == 0)
                break;

                num++;
            }
            Console.WriteLine("5와 7의 최소 공배수 : {0}", num);
            #endregion

            #region continue
            int tot = 0;
            int j = 0;

            while (j <= 10)
            {
                j++;

                if (j % 2 == 1)
                continue;

                tot += j;
            }
            Console.WriteLine("1 ~ 10 까지 짝수의 합 : {0}", tot);
            #endregion

        }
    }
}
