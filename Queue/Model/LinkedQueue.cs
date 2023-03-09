namespace Queue.Model
{
    public class LinkedQueue<T>
    {
        private Item<T> head;
        private Item<T> tail;
        public int Count { get; set; }
        public LinkedQueue() { }
        public LinkedQueue(T data)
        {
            SetData(data);
        }
        private void SetData(T data)
        {
            var item = new Item<T>(data);
            Count = 1;
            head = item;
            tail = item;
        }

        public void Enqueue(T data)
        {
            if (Count == 0)
            {
                SetData(data);
                return;
            }
            var item = new Item<T>(data)
            {
                Next = head
            };
            tail = item;
            Count++;
        }
        public T Dequeue()
        {
            var data = head.Data;

            var curr = tail.Next;
            var previous = tail;
            while (curr != null && curr.Next != null)
            {
                previous = curr;
                curr = curr.Next;
            }
            tail = previous;
            Count--;
            tail.Next = null;
            return data;
        }
        public T Peek()
        {
            return head.Data;
        }
    }
}
