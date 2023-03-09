using System.Collections.Generic;

namespace Hash_Table
{
    public class Item<T>
    {
        public int Key { get; set; }
        public List<T> Nodes { get; set; }
        public Item()
        {
            Key = Key;
            Nodes = new List<T>();
        }
    }
}
