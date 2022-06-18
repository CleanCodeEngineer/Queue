using System;
using System.Collections.Generic;

namespace Queue
{
    public class QueueTwoStacks
    {
        private Stack<int> _inStack = new Stack<int>();
        private Stack<int> _outStack = new Stack<int>();

        public void Enqueue(int item)
        {
            _inStack.Push(item);
        }

        public int Dequeue()
        {
            if (_outStack.Count == 0)
            {
                // Move items from inStack to outStack, reversing order
                while (_inStack.Count > 0)
                {
                    int newestInStackItem = _inStack.Pop();
                    _outStack.Push(newestInStackItem);
                }

                if (_outStack.Count == 0)
                {
                    throw new InvalidOperationException("Can't dequeue from empty queue!");
                }
            }

            return _outStack.Pop();
        }
    }
}
