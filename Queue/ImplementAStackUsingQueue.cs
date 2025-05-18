using System;

namespace Queue
{
    // Question from bytebybyte
    // Implement a stack with basic functionality (push and pop) using queues to store the data.
    public class ImplementAStackUsingQueue
    {
        // STack: LILO
        // Queue: FIFO 
        // InputQueue : 2 1
        // OutputQueue: 3
        // InputQueue : 3 
        // in 1 queue we should always have one element which is the one we pop

        public class MyStack
        {
            private Queue<int> q1;
            private Queue<int> q2;

            public MyStack()
            {
                q1 = new Queue<int>();
                q2 = new Queue<int>();
            }

            public void Push(int x)
            {
                // Push into q2
                q2.Enqueue(x);

                // Push all elements of q1 into q2
                while (q1.Count > 0)
                {
                    q2.Enqueue(q1.Dequeue());
                }

                // Swap q1 and q2
                var temp = q1;
                q1 = q2;
                q2 = temp;
            }

            public int Pop()
            {
                return q1.Dequeue();
            }

            public int Top()
            {
                return q1.Peek();
            }

            public bool Empty()
            {
                return q1.Count == 0;
            }
        }
    }
}
