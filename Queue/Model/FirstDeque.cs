using System.Collections.Generic;
using System.Linq;

namespace Queue.Model
{
    public class FirstDeque<T>
    {
        private List<T> items = new List<T>();
        private T Head => items.Last();
        private T Tail => items.First();
        public int Count => items.Count;
        public FirstDeque() { }
        public FirstDeque(T data)
        {
            items.Add(data);
        }
        public void PushB(T data)
        {
            items.Insert(0, data);
        }
        public void PushF(T data)
        {
            items.Add(data);
        }
        public T PopB()
        {
            var item = Tail;
            items.Remove(item);
            return item;
        }
        public T PopF()
        {
            var item = Head;
            items.Remove(item);
            return item;
        }
        public T PeekB()
        {
            return Tail;
        }
        public T PeekF()
        {
            return Head;
        }
    }
}
