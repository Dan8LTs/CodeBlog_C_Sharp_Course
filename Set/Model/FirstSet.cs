using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Set.Model
{
    public class FirstSet<T> : IEnumerable
    {
        private List<T> items = new List<T>();
        public int Count => items.Count;
        public FirstSet() { }
        public FirstSet(T item)
        {
            items.Add(item);
        }
        public FirstSet(IEnumerable<T> items)
        {
            this.items = items.ToList();
        }
        public void Add(T item)
        {
            if (items.Contains(item))
            {
                return;
            }
            items.Add(item);
        }
        public void Remove(T item)
        {
            items.Remove(item);
        }
        public FirstSet<T> Union(FirstSet<T> set)
        {
            FirstSet<T> res = new FirstSet<T>(set.items);
            {
                foreach (var i in items)
                {
                    res.Add(i);
                }
                foreach (var i in set.items)
                {
                    res.Add(i);
                }
                return res;
            }
        }
        public FirstSet<T> Intersection(FirstSet<T> set)
        {
            var result = new FirstSet<T>();
            FirstSet<T> big;
            FirstSet<T> small;

            if (Count >= set.Count)
            {
                big = this;
                small = set;
            }
            else
            {
                big = set;
                small = this;
            }

            foreach (var item1 in small.items)
            {
                foreach (var item2 in big.items)
                {
                    if (item1.Equals(item2))
                    {
                        result.Add(item1);
                        break;
                    }
                }
            }

            return result;
        }

        public FirstSet<T> Difference(FirstSet<T> set)
        {
            FirstSet<T> res = new FirstSet<T>(items);
            foreach (var item in set.items)
            {
                res.Remove(item);
            }
            return res;
        }

        public bool Subset(FirstSet<T> set)
        {
            foreach (var i in items)
            {
                var equals = false;
                foreach (var item in set.items)
                {
                    if (i.Equals(item))
                    {
                        equals = true;
                        break;
                    }
                }
                if (!equals)
                {
                    return false;
                }
            }
            return true;
        }
        public IEnumerator GetEnumerator()
        {
            return items.GetEnumerator();
        }

        public FirstSet<T> SymmetricDifference(FirstSet<T> set)
        {
            var res = new FirstSet<T>();

            foreach (var i in items)
            {
                var equals = false;
                foreach (var item in set.items)
                {
                    if (i.Equals(item))
                    {
                        equals = true;
                        break;
                    }
                }
                if (equals == false)
                {
                    res.Add(i);
                }
            }
            foreach (var i in set.items)
            {
                var equals = false;
                foreach (var item in items)
                {
                    if (i.Equals(item))
                    {
                        equals = true;
                        break;
                    }
                }
                if (equals == false)
                {
                    res.Add(i);
                }
            }
            return res;
        }
    }
}
