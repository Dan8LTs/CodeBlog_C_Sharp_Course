using System.Collections;

namespace Linked_list.Model
{
    public class CircularDuplexList<T> : IEnumerable
    {
        public DuplexItem<T> Head { get; set; }
        public int Count { get; set; }
        public CircularDuplexList() { }
        public CircularDuplexList(T data)
        {
            SetHeadItem(data);
        }
        public void Add(T data)
        {
            if (Count == 0)
            {
                SetHeadItem(data);
                return;
            }

            var item = new DuplexItem<T>(data);
            item.NextItem = Head;
            item.PreviousItem = Head.PreviousItem;
            Head.PreviousItem.NextItem = item;
            Head.PreviousItem = item;
            Count++;
        }
        public void Delete(T data)
        {
            if (Head.Data.Equals(data))
            {
                Remove(Head);
                Head = Head.NextItem;
                return;
            }

            var curr = Head;
            for (int i = Count; i > 0; i--)
            {
                if (curr != null && curr.Data.Equals(data))
                {
                    Remove(curr);
                }
                curr = curr.NextItem;
            }
        }

        public void Remove(DuplexItem<T> curr)
        {
            curr.NextItem.PreviousItem = curr.PreviousItem;
            curr.PreviousItem.NextItem = curr.NextItem;
            Count--;
        }
        private void SetHeadItem(T data)
        {
            Head = new DuplexItem<T>(data);
            Head.NextItem = Head;
            Head.PreviousItem = Head;
            Count = 1;
        }

        public IEnumerator GetEnumerator()
        {
            var curr = Head;
            for (int i = 0; i < Count; i++)
            {
                yield return curr;
                curr = curr.NextItem;
            }
        }
    }
}
