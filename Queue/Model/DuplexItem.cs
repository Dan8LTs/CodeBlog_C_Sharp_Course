﻿namespace Queue.Model
{
    public class DuplexItem<T>
    {
        public T Data { get; set; }
        public DuplexItem<T> Next { get; set; }
        public DuplexItem<T> Prev { get; set; }
        public DuplexItem(T data)
        {
            Data = data;
        }
        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
