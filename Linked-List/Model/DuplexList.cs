using System.Collections;
using System.Collections.Generic;

namespace Linked_list.Model
{
    public class DuplexList<T> : IEnumerable<T>
    {
        public DuplexItem<T> Head { get; set; }
        public DuplexItem<T> Tail { get; set; }
        public int Count { get; set; }
        public DuplexList() { }
        public DuplexList(T data)
        {
            var item = new DuplexItem<T>(data);
            Tail = item;
            Head = item;
            Count = 1;
        }
        public void Add(T data)
        {
            var item = new DuplexItem<T>(data);
            if (Count == 0)
            {
                Tail = item;
                Head = item;
                Count = 1;
                return;
            }
            Tail.NextItem = item;
            item.PreviousItem = Tail;
            Tail = item;
            Count++;
        }

        public void Delete(T data)
        {
            var current = Head;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    current.PreviousItem.NextItem = current.NextItem;
                    current.NextItem.PreviousItem = current.PreviousItem;
                    Count--;
                    return;
                }

                current = current.NextItem;
            }
        }

        public DuplexList<T> Reverse()
        {
            var res = new DuplexList<T>();
            var current = Tail;

            while (current != null)
            {
                res.Add(current.Data);
            }
            return res;
        }
        public IEnumerator GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current;
                current = current.NextItem;
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return (IEnumerator<T>)GetEnumerator();
        }
    }
}
