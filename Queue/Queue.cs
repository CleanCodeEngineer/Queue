using System;


namespace Queue
{
    //  Implementing a queue using a singly linked list,
    public class Queue<T>
    {
        private class QueueNode
        {
            public T Data;
            public QueueNode Next;

            public QueueNode(T data)
            {
                this.Data = data;
            }
        }

        private QueueNode first;
        private QueueNode last;
        private int count = 0;
        public int Count => count;  // Property you can access with q1.Count

        // Enqueue (Add item to the end of the queue)
        public void Enqueue(T item)
        {
            QueueNode newNode = new QueueNode(item);

            if (last != null)
            {
                last.Next = newNode;
            }

            last = newNode;

            if (first == null)
            {
                first = last;
            }

            count++;
        }

        // Dequeue (Remove item from the front of the queue)
        public T Dequeue()
        {
            if (IsEmpty()) throw new InvalidOperationException("Queue is empty");

            T value = first.Data;
            first = first.Next;

            if (first == null)
                last = null;

            count--;
            return value;
        }

        public T Peek()
        {
            if (IsEmpty()) throw new InvalidOperationException("Queue is empty");

            return first.Data;
        }

        public Boolean IsEmpty()
        {
            return count == 0;
        }
    }
}
