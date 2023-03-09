using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Map_dictionary_
{
    public class FirstMap<TKey, TValue> : IEnumerable
    {
        private List<Item<TKey, TValue>> Elements = new List<Item<TKey, TValue>>();
        private List<TKey> Keys = new List<TKey>();
        public FirstMap() {  }
        public void Add(Item<TKey, TValue> item)
        {
            if (!Keys.Contains(item.Key))
            {
                Keys.Add(item.Key);
                Elements.Add(item);
            }
        }
        public TValue Search(TKey key)
        {
            if (Keys.Contains(key))
            {
                return Elements.Single(i => i.Key.Equals(key)).Value;
            }
            return default(TValue);
        }
        public void Remove(TKey key)
        {
            if (Keys.Contains(key))
            {
                Keys.Remove(key);
                Elements.Remove(Elements.Single(i => i.Key.Equals(key)));
            }
        }

        public IEnumerator GetEnumerator()
        {
            return Elements.GetEnumerator();
        }
    }
}
