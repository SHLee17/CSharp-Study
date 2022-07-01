using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06
{
    internal class _5_Indexer
    {
        class MyList
        {
            int[] arry;

            public MyList()
            {
                arry = new int[3];
            }

            public int this[int i]
            {
                get { return arry[i]; }
                set
                {
                    if (i < arry.Length)
                        arry[i] = value;
                    else
                        Console.WriteLine("더 이상 데이터를 저장 할 수 없습니다.");
                }
            }
                public int Length() { return arry.Length; }
        }
        static void Main1(string[] args)
        {
            MyList myList = new MyList();

            myList[0] = 100;
            myList[1] = 200;
            myList[2] = 300;
            myList[3] = 300;

            for (int i = 0; i < myList.Length(); i++)
                Console.WriteLine(myList[i]);
        }
    }

}

