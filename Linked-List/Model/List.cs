using System.Collections;

namespace Linked_list.Model
{
    /// <summary>
    /// Односвязный список.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class List<T> : IEnumerable
    {
        /// <summary>
        /// Первый элемент.
        /// </summary>
        public Item<T> Head { get; private set; }
        /// <summary>
        /// Последний элемент.
        /// </summary>
        public Item<T> Tail { get; private set; }
        /// <summary>
        /// Количество элементво списка.
        /// </summary>
        public int Count { get; private set; }

        public List()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public List(T data)
        {
            Set(data);
        }
        /// <summary>
        /// Добавить в коней списка.
        /// </summary>
        /// <param name="data"></param>
        public void Add(T data)
        {
            var element = new Item<T>(data);

            if (Tail != null)
            {
                Tail.Next = element;
                Tail = element;
                Count++;
            }
            else
            {
                Set(data);
            }
        }
        /// <summary>
        /// Удалить данные из списка.
        /// </summary>
        /// <param name="data"></param>
        public void Delete(T data)
        {
            if (Head != null)
            {
                if (Head.Data.Equals(data))
                {
                    Head = Head.Next;
                    Count--;
                    return;
                }

                var current = Head.Next;
                var previous = Head;

                while (current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        previous.Next = current.Next;
                        Count--;
                        return;
                    }

                    previous = current;
                    current = current.Next;
                }
            }
            else
            {
                Set(data);
            }
        }
        /// <summary>
        /// Создание списка.
        /// </summary>

        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
        /// <summary>
        /// Добавить элемент.
        /// </summary>
        /// <param name="item"></param>
        private void Set(T data)
        {
            var item = new Item<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }
        /// <summary>
        /// Перечисление элементов списка.
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
        /// <summary>
        /// Добавление данных в начало списка.
        /// </summary>
        /// <param name="data"></param>
        public void AppendHead(T data)
        {
            var item = new Item<T>(data)
            {
                Next = Head
            };

            Head = item;
            Count++;
        }
        /// <summary>
        /// Добавить элемент после другого.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="data"></param>
        public void InsertAfter(T target, T data)
        {
            if (Head != null)
            {
                var current = Head;
                while (current != null)
                {
                    if (current.Data.Equals(target))
                    {
                        var item = new Item<T>(data);
                        item.Next = current.Next;
                        current.Next = item;
                        Count++;
                        return;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }
            }
            else
            {
                Set(data);
                Add(data);
            }
        }

        public override string ToString()
        {
            return "List" + Count + "items";
        }
    }
}
