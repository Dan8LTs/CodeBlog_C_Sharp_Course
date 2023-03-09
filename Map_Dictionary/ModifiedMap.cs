using System;
using System.Collections;

namespace Map_dictionary_
{
    public class ModifiedMap<TKey, TValue> : IEnumerable
    {
        private int size = 50;
        private Item<TKey, TValue>[] Elements;
        public ModifiedMap()
        {
            Elements = new Item<TKey, TValue>[size];
        }
        public void Add(Item<TKey, TValue> item)
        {
            var hash = GetHash(item.Key);
            if (Elements[hash] == null)
            {
                Elements[hash] = item;
            }
            else
            {
                var current = false;
                for (var i = hash; i < size; i++)
                {
                    if (Elements[i] == null)
                    {
                        Elements[i] = item;
                        current = true;
                        break;
                    }
                    if (Elements[i].Key.Equals(item.Key))
                    {
                        return;
                    }
                }
                if (!current)
                {
                    for (var i = 0; i < hash; i++)
                    {
                        if (Elements[i] == null)
                        {
                            Elements[i] = item;
                            current = true;
                            break;
                        }
                        if (Elements[i].Key.Equals(item.Key))
                        {
                            return;
                        }
                    }
                }
                if (!current)
                {
                    throw new ArgumentNullException("Dictionary is full");
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var item in Elements)
            {
                if (item != null)
                {
                    yield return item;
                }
            }
        }

        public void Remove(TKey key)
        {
            var hash = GetHash(key);
            if (Elements[hash].Key.Equals(key))
            {
                Elements[hash] = null;
            }
            else
            {
                var current = false;
                for (var i = hash; i < size; i++)
                {
                    if (Elements[i] == null)
                    {
                        return;
                    }
                    if (Elements[i].Key.Equals(key))
                    {
                        Elements[i] = null;
                        return;
                    }
                }
                if (!current)
                {
                    for (var i = 0; i < hash; i++)
                    {
                        if (Elements[i] == null)
                        {
                            return;
                        }
                        if (Elements[i].Key.Equals(key))
                        {
                            Elements[hash] = null;
                            return;
                        }
                    }
                }
            }
        }
        public TValue Search(TKey key)
        {
            var hash = GetHash(key);
            if (Elements[hash] == null)
            {
                return default(TValue);
            }
            if (Elements[hash].Key.Equals(key))
            {
                return Elements[hash].Value;
            }
            else
            {
                var current = false;
                for (var i = hash; i < size; i++)
                {
                    if (Elements[i] == null)
                    {
                        return default(TValue);
                    }
                    if (Elements[i].Key.Equals(key))
                    {
                        return Elements[i].Value;
                    }
                }
                if (!current)
                {
                    for (var i = 0; i < hash; i++)
                    {
                        if (Elements[i] == null)
                        {
                            return default(TValue);
                        }
                        if (Elements[i].Key.Equals(key))
                        {
                            return Elements[i].Value;
                        }
                    }
                }
            }
            return default(TValue);
        }

        private int GetHash(TKey key)
        {
            return key.GetHashCode() % size;
        }
    }
}
