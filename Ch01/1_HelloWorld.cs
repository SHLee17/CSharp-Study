using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022 06 02
 * 이름 : 이동건
 * 내용 : C# 개발환경 설정 밑 Hello World 출력
 */
namespace Ch01
{
    internal class _1_HelloWorld
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hollo World!");
            Console.WriteLine("Hollo C#!");

            Console.Write("Hollo \t");
            Console.Write("Korea \n");

            // 포맷출력
            Console.WriteLine("{0} ,{1}", "Hello", "Busan");

            int[] arr = { 1, 3, 5, 6, 7, 8, 9, 2, 4 };

            heapSort(arr);
            Console.WriteLine(string.Join(",", arr));
        }

        static void heapSort(int[] arr)
        {
            int i, temp, length = arr.Length;
            for (i = length / 2 - 1; i >= 0; i--) heapHeapify(arr, length, i);
            for (i = length - 1; i >= 0; i--)
            {
                temp = arr[0]; arr[0] = arr[i]; arr[i] = temp;
                heapHeapify(arr, i, 0);
            }
        }
        static void heapHeapify(int[] arr, int length, int i)
        {
            int left = 2 * i + 1, right = 2 * i + 2;
            int temp, largest = i;
            if (left < length && arr[left] > arr[largest]) largest = left;
            if (right < length && arr[right] > arr[largest]) largest = right;
            if (largest != i)
            {
                temp = arr[i]; arr[i] = arr[largest]; arr[largest] = temp;
                heapHeapify(arr, length, largest);
            }
            Console.WriteLine(string.Join(",", arr));
        }
    }
}
