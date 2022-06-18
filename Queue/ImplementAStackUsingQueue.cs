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
        public class Stack
        {
            public Queue<int> Queue1 { get; set; }
            public Queue<int> Queue2 { get; set; }

            public Stack()
            {
                Queue1 = new Queue<int>();
                Queue2 = new Queue<int>();
            }

            public void Push(int value)
            {
                if (Queue1.isEmpty())
                    Queue1.add(value);
                else if (Queue2.isEmpty())
                    Queue2.add(value);
                else
                {
                    int top1 = Queue1.remove();
                    int top2 = Queue2.remove();

                    if (Queue2.isEmpty() && Queue1.isEmpty())
                    {
                        Queue2.add(value);
                        Queue1.add(top1);
                        Queue1.add(top2);
                    }
                    else if (Queue2.isEmpty())
                    {
                        Queue2.add(value);
                        Queue1.add(top1);
                        Queue1.add(top2);
                    }
                    else if (Queue1.isEmpty())
                    {
                        Queue1.add(value);
                        Queue2.add(top2);
                        Queue2.add(top1);
                    }
                }
            }

            public int Pop()
            {
                if (Queue2.isEmpty() && Queue1.isEmpty()) throw new Exception("Stack is empty");

                int top = 0;

                if (Queue2.isEmpty() && !Queue1.isEmpty())
                {
                    top = Queue1.remove();
                }
                else if (Queue1.isEmpty() && !Queue2.isEmpty())
                {
                    top = Queue2.remove();
                }
                else if (!Queue2.isEmpty() && !Queue1.isEmpty())
                {
                    int top1 = Queue1.remove();
                    int top2 = Queue2.remove();

                    if (Queue1.isEmpty() && Queue2.isEmpty())
                    {
                        top = top1;
                        Queue2.add(top2);
                    }
                    else if (Queue1.isEmpty())
                    {
                        top = top1;
                        Queue1.add(top2);
                    }
                    else if (Queue2.isEmpty())
                    {
                        top = top2;
                        Queue2.add(top1);
                    }
                }

                return top;
            }
        }
    }
}
