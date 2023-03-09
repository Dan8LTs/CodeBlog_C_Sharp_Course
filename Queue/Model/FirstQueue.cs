using System.Collections.Generic;
using System.Linq;

namespace Queue.Model
{
    public class FirstQueue<T>
    {
        private List<T> items = new List<T>();
        public int Count => items.Count;
        private T Head => items.Last();
        private T Tail => items.First();
        public FirstQueue() { }
        public FirstQueue(T data)
        {
            items.Add(data);
        }
        public void Enqueue(T data)
        {
            items.Insert(0, data);
        }
        public T Dequeue()
        {
            var item = Tail;
            items.Remove(item);
            return item;
        }
        public T Peek()
        {
            return Head;
        }
    }
}
