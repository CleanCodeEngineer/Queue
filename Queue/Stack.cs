namespace Queue
{
    public class Stack
    {
        private Queue<int> primary = new Queue<int>();
        private Queue<int> secondary = new Queue<int>();

        public Stack() { }

        // With help of seconday queue, values are being saved in reverse order in primary queue so when we pop we get reverse order compare to what we push.
        public void push(int x)
        {
            secondary.Enqueue(x);

            while (!primary.IsEmpty())
            {
                secondary.Enqueue(primary.Dequeue());
            }

            primary = secondary;
            secondary = new Queue<int>();
        }

        public int pop()
        {
            if (primary.IsEmpty()) throw new System.Exception("Stack is empty!");

            return primary.Dequeue();
        }
    }
}
