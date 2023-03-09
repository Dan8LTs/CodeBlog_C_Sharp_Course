using System.Collections;
using System.Collections.Generic;

namespace BinaryHeap
{
    public class Heap : IEnumerable
    {
        private List<int> items = new List<int>();
        public int Count => items.Count;
        public int? Max()
        {
            if (Count > 0)
            {
                return items[0];
            }
            else
            {
                return null;
            }
        }

        public Heap() { }

        public Heap(List<int> items)
        {
            this.items.AddRange(items);
            for (int i = Count; i >= 0; i--)
            {
                Sort(i);
            }
        }

        public void Add(int item)
        {
            items.Add(item);

            var indexCurrent = Count - 1;
            var indexParent = GetParent(indexCurrent);

            while (indexCurrent > 0 && items[indexParent] < items[indexCurrent])
            {
                SwapCurrent(indexCurrent, indexParent);
                indexCurrent = indexParent;
                indexParent = GetParent(indexCurrent);
            }
        }

        public int GetMax()
        {
            var result = items[0];
            items[0] = items[Count - 1];
            items.RemoveAt(Count - 1);
            Sort(0);
            return result;
        }

        private void Sort(int indexCurrent)
        {
            int indexMax = indexCurrent;
            int indexLeft;
            int indexRight;

            while (indexCurrent < Count)
            {
                indexLeft = indexCurrent * 2 + 1;
                indexRight = indexCurrent * 2 + 2;

                if (indexLeft < Count && items[indexLeft] > items[indexMax])
                {
                    indexMax = indexLeft;
                }

                if (indexRight < Count && items[indexRight] > items[indexMax])
                {
                    indexMax = indexRight;
                }

                if (indexMax == indexCurrent)
                {
                    break;
                }

                SwapCurrent(indexCurrent, indexMax);
                indexCurrent = indexMax;
            }
        }

        private void SwapCurrent(int current, int parent)
        {
            int temp = items[current];
            items[current] = items[parent];
            items[parent] = temp;
        }


        private static int GetParent(int current)
        {
            return (current - 1) / 2;
        }

        public IEnumerator GetEnumerator()
        {
            while (Count > 0)
            {
                yield return GetMax();
            }
        }
    }
}
