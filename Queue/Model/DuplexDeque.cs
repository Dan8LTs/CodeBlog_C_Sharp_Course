namespace Queue.Model
{
    public class DuplexDeque<T>
    {
        private DuplexItem<T> Head;
        private DuplexItem<T> Tail;
        public int Count { get; private set; }
        public DuplexDeque() { }
        public DuplexDeque(T data)
        {
            SetData(data);
        }

        private void SetData(T data)
        {
            var item = new DuplexItem<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }

        public void PushB(T data)
        {
            if (Count == 0)
            {
                SetData(data);
                return;
            }
            var item = new DuplexItem<T>(data);
            item.Next = Tail;
            Tail.Prev = item;
            Tail = item;
            Count++;
        }
        public void PushF(T data)
        {
            if (Count == 0)
            {
                SetData(data);
                return;
            }
            var item = new DuplexItem<T>(data);
            item.Prev = Head;
            Head.Next = item;
            Head = item;
            Count++;
        }
        public T PopB()
        {
            if (Count == 0)
            {
                var res = Tail.Data;
                var curr = Tail.Next;
                curr.Prev = null;
                Tail = curr;
                Count++;
                return res;
            }
            else
            {
                return default(T);
            }
        }
        public T PopF()
        {
            if (Count == 0)
            {
                var res = Head.Data;
                var curr = Head.Next;
                curr.Prev = null;
                Tail = curr;
                Count--;
                return res;
            }
            else
            {
                return default(T);
            }
        }
        public T PeekB()
        {
            return Tail.Data;
        }
        public T PeekF()
        {
            return Head.Data;
        }
    }
}
