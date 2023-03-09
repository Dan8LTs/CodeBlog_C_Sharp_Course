using System.Linq;

namespace Queue.Model
{
    public class ArrayQueue<T>
    {
        private T[] items;
        public int Count { get; private set; }
        private T Head => items[Count > 0 ? Count - 1 : 0];
        private T Tail => items[0];
        private int MaxCount => items.Length;
        public ArrayQueue(int size)
        {
            items = new T[size];
            Count = 0;
        }
        public ArrayQueue(int size, T data)
        {
            items = new T[size];
            items[0] = data;
            Count = 1;
        }
        public void Enqueue(T data)
        {
            var res = (new T[] { data }).Concat(items);
            items = res.ToArray();
            Count++;
        }
        public T Dequeue()
        {
            var item = Head;
            Count--;
            return item;
        }
        public T Peek()
        {
            return Head;
        }
    }
}
