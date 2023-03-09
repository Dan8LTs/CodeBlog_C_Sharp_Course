using System;
using System.Collections.Generic;

namespace Hash_Table
{
    public class ModifiedHashtable<TKey, TValue>
    {
        private List<TValue>[] elements;
        public ModifiedHashtable(int size)
        {
            elements = new List<TValue>[size];
        }
        public void Add(TKey key, TValue value)
        {
            var k = GetHash(key);
            if (elements[k] == null)
            {
                elements[k] = new List<TValue>() { value };
            }
            else
            {
                elements[k].Add(value);
            }
        }
        public bool Search(TKey key, TValue item)
        {
            var k = GetHash(key);
            return elements[k]?.Contains(item) ?? false;
        }
        public int GetHash(TKey key)
        {
            return Int32.Parse(key.ToString().Substring(0, 1));
        }
    }
}
