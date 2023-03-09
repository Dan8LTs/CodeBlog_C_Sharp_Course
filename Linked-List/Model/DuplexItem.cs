namespace Linked_list.Model
{
    public class DuplexItem<T>
    {
        public T Data { get; set; }
        public DuplexItem<T> PreviousItem { get; set; }
        public DuplexItem<T> NextItem { get; set; }

        public DuplexItem(T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
