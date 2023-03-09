namespace Hash_Table
{
    public class FirstHashtable<T>
    {
        private T[] elements;
        public FirstHashtable(int size)
        {
            elements = new T[size];
        }
        public void Add(T item)
        {
            var key = GetHash(item);
            elements[key] = item;
        }
        public bool Search(T item)
        {
            var key = GetHash(item);
            return elements[key].Equals(item);
        }
        public int GetHash(T item)
        {
            return item.ToString().Length % elements.Length;
        }
    }
}
