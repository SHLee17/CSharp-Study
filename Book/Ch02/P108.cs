using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P108
    {
        static void Main1(string[] args)
        {
            long longNum = 52273;
            int intNum = (int)longNum;
            Console.WriteLine(intNum) ;

            double doubleNum = 52.27310332;
            int doubleToInt = (int)doubleNum;
            Console.WriteLine(doubleToInt);

            int tempInt = 2147483647;

            long intToLong = tempInt;
            Console.WriteLine(intToLong);
            double intToDouble = intNum;
            Console.WriteLine(intToDouble);

        }
    }

}
