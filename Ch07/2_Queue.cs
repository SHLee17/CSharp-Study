using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch07
{
    internal class _2_Queue
    {
        static void Main1(string[] args)
        {
            //first in first out
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("1");
            queue.Enqueue("2");
            queue.Enqueue("3");
            queue.Enqueue("4");
            queue.Enqueue("5");

            while (queue.Count > 0)
                Console.WriteLine(queue.Dequeue());
        }
    }
}
