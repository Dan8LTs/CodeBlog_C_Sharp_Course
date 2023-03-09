using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack.Model
{
    public class Stack1<T>
    {
        private List<T> items = new List<T>();

        public int Count => items.Count;

        public bool IsEmpty => items.Count == 0;
        public void Push(T item)
        {
            items.Add(item);
        }

        public void Clear()
        {
            items.Clear();
        }
        public T Pop()
        {
            if (!IsEmpty)
            {
                var item = items.LastOrDefault();
                items.Remove(item);
                return item;
            }
            else
            {
                throw new NullReferenceException("Stack is empty");
            }
        }

        public T Peek()
        {
            if (!IsEmpty)
            {
                var item = items.LastOrDefault();
                return item;
            }
            else
            {
                throw new NullReferenceException("Stack is empty");
            }
        }

        public override string ToString()
        {
            return $"Stack has {Count} items";
        }

        public object Clone()
        {
            var newStack = new Stack1<T>();
            newStack.items = new List<T>(items);
            return newStack;
        }
    }
}
