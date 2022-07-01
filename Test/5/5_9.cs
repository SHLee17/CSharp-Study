using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._5
{
   class MyStack
    {
        const int maxSize = 10;
        int[] arr = new int[maxSize];
        int top;

        public MyStack() => top = 0;
        public void Push(int val)
        {
            if(top < maxSize)
            {
                arr[top] = val;
                top++;
            }
            else
            {
                Console.WriteLine("Stack Full");
                return;
            }
        }
        public int Pop()
        {
            if(top > 0)
            {
                top--;
                return arr[top];
            }
            else
            {
                Console.WriteLine("Stack Empty");
                return 0;
            }
        }
    }
    internal class _5_9
    {
        static void Main1(string[] args)
        {
            MyStack myStack = new MyStack();
            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                int val = rand.Next(1, 100);
                myStack.Push(val);
                Console.WriteLine($"Push({val})");
            }

            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Pop() = {myStack.Pop()}");
            }
        }
    }
}
