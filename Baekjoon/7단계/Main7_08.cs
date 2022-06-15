using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._7단계
{
    internal class Main7_08
    {
        static void Main(string[] args)
        {

            string[] inputs = Console.ReadLine().Split();
            int i = 0;

            List<List<int>> numList = new List<List<int>>();

            List<int> add = new List<int>();

            foreach (var item in inputs)
            {
                List<int> temp = new List<int>();
                for (i = item.Length - 1; i >= 0; i--)
                    temp.Add(int.Parse(item[i].ToString()));

                numList.Add(temp);
            }


            int length = numList[0].Count > numList[1].Count ? numList[0].Count : numList[1].Count;
            int p = 0;
            i = 0;

            while (true)
            {
                if (numList[0].Count <= i || numList[1].Count <= i)
                {
                    int j = numList[0].Count <= i ? 1 : 0;
                    while (numList[j].Count > i)
                    {
          
                            p = numList[j][i] + p;
                            if(p >= 10) 
                            {
                                add.Add(p % 10);
                                p = 1;
                            }
                            else 
                            {
                                add.Add(p);
                                p = 0;
                            }

                            i++;
                    }
                    if (p == 1)
                        add.Add(p);
                    break;
                }

                p = numList[0][i] + numList[1][i] + p;
                if (p >= 10)
                {
                    add.Add(p % 10);
                    p = 1;
                }
                else
                {
                    add.Add(p);
                    p = 0;
                }
                i++;
            }

            add.Reverse();
            add.ForEach(x => Console.Write(x));

        }
    }
}



//BigInteger[] nums = new BigInteger[2]
//{
//    BigInteger.Parse(inputs[0]),
//    BigInteger.Parse(inputs[1]),
//};

//Console.WriteLine(nums[0] + nums[1]);


//    string a = "";
//    int index0 = inputs[0].Length - 1;
//    int index1 = inputs[1].Length - 1;
//    int plus = 0;

//    while (true)
//    {
//        if (0 > index1 || 0 > index0)
//        {
//            string tempStr = 0 < index0 ? inputs[0] : inputs[1];
//            int index = 0 < index0 ? index0 : index1;
//            while (plus == 1)
//            {
//                if (index >= 0)
//                {
//                    plus = ToInt(tempStr[index]) + plus;
//                    if (plus >= 10)
//                    {
//                        plus -= 10;
//                        a = plus + a;
//                        plus = 1;
//                    }
//                    else
//                    {
//                        a = plus + a;
//                        plus = 0;
//                    }
//                    index--;
//                }
//                else
//                {
//                    a = plus + a;
//                    plus = 0;
//                }

//            }
//            Console.WriteLine(a);
//            break;
//        }

//        plus = ToInt(inputs[0][index0]) + ToInt(inputs[1][index1]) + plus;

//        if (plus >= 10)
//        {
//            plus -= 10;
//            a = plus + a;
//            plus = 1;
//        }
//        else 
//        {
//            a = plus + a; 
//            plus = 0;
//        }

//        index0--;
//        index1--;
//    }


//}

//static int ToInt(char c) { return int.Parse(c.ToString()); }

