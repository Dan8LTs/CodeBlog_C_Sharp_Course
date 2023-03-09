using System;

namespace Linked_list.Model
{
    public class Item<T>
    {

        private T data = default;
        /// <summary>
        /// Данные в ячейке списка.
        /// </summary>
        public T Data
        {
            get => data;
            set
            {
                if (value != null)
                    data = value;
                else
                    throw new ArgumentNullException(nameof(value));
            }
        }

        /// <summary>
        /// Следующая ячейка списка.
        /// </summary>
        public Item<T> Next { get; set; }

        public Item(T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
