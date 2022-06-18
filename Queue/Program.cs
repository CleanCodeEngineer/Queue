using System;
using static Queue.ImplementAStackUsingQueue;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            //int top = 0;
            //QueueTwoStacks queue = new QueueTwoStacks();

            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);

            //top = queue.Dequeue();

            //Console.WriteLine("Top: " + top);

            //top = queue.Dequeue();

            //Console.WriteLine("Top: " + top);

            //queue.Enqueue(4);
            //queue.Enqueue(5);
            //queue.Enqueue(6);

            //top = queue.Dequeue();

            //Console.WriteLine("Top: " + top);

            //top = queue.Dequeue();

            //Console.WriteLine("Top: " + top);

            //top = queue.Dequeue();

            //Console.WriteLine("Top: " + top);

            //top = queue.Dequeue();

            //Console.WriteLine("Top: " + top);

            //top = queue.Dequeue();

            //Console.WriteLine("Top: " + top);

            Stack stack = new Stack();

            stack.push(1);
            stack.push(2);
            stack.push(3);

            int top1 = stack.pop();
            int top2 = stack.pop();

            stack.push(4);

            int top3 = stack.pop();
            int top4 = stack.pop();

        }
    }
}
