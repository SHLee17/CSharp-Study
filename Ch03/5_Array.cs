using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03
{
    internal class _5_Array
    {
        static void Main(string[] args)
        {
            #region 기본배열
            int[] arr1 = new int[3];

            arr1[0] = 1;
            arr1[1] = 2;
            arr1[2] = 3;

            Console.WriteLine("arr1 1번째 데이터 : " + arr1[0]);
            Console.WriteLine("arr1 2번째 데이터 : " + arr1[1]);
            Console.WriteLine("arr1 3번째 데이터 : " + arr1[2]);
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
                Console.WriteLine("arr1 {0}번째 데이터 : {1}", i , arr1[i]);

            Console.WriteLine();

            //생성 초기화
            int[] nums = { 1, 2, 3, 4, 5 };
            char[] chars = { 'A', 'B', 'C' };
            string[] cities = { "서울", "대전", "대구", "부산", "광주" };

            Console.WriteLine("nums 길이 : {0}",nums.Length );
            Console.WriteLine("chars 길이 : {0}", chars.Length);
            Console.WriteLine("cities 길이 : {0}", cities.Length);


            foreach (int item in nums)
                Console.Write("{0} ",item);
            Console.WriteLine();
            foreach (char item in chars)
                Console.Write("{0} ", item);
            Console.WriteLine();
            foreach (string item in cities)
                Console.Write("{0} ", item);
            Console.WriteLine();
            #endregion

            #region 다차원 배열

            int[] arr1d = { 10, 20, 30, 40, 50, 60 };
            int total = 0;
            foreach (int item in arr1d)
                total += item;
            Console.WriteLine(total);

            int[,] arr2d = { 
                { 1, 2, 3, 4 }, 
                { 5, 6, 7, 8 }, 
                { 9, 10, 11, 12 } };

            Console.WriteLine("arr2d[0,0] : {0}", arr2d[0,0]);
            Console.WriteLine("arr2d[0,2] : {0}", arr2d[0,2]);
            Console.WriteLine("arr2d[1,2] : {0}", arr2d[1,2]);
            Console.WriteLine("arr2d[2,3] : {0}", arr2d[2,3]);

            int[,,] arr3d =
            {
                {
                    {1,2,3 },
                    {4,5,6 },
                    {7,8,9 }
                },
                {
                    {11,12,13 },
                    {14,15,16 },
                    {17,18,19 }
                },
                {
                    {20, 21, 22 },
                    {23,24,25 },
                    {26,27,28 }
                },
            };

            //3 5 11 17 25
            Console.WriteLine(arr3d[0,0,2]);
            Console.WriteLine(arr3d[0, 1, 1]);
            Console.WriteLine(arr3d[1, 0, 0]);
            Console.WriteLine(arr3d[1, 2, 0]);
            Console.WriteLine(arr3d[2, 1, 2]);




            #endregion
        }

    }
}
