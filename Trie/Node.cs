﻿using System.Collections.Generic;

namespace Trie
{
    public class Node<T>
    {
        public char Symbol { get; set; }
        public T Data { get; set; }
        public bool IsWord { get; set; }
        public string Prefix { get; set; }
        public Dictionary<char, Node<T>> SubNodes { get; set; }

        public Node(char symbol, T data, string prefix)
        {
            Symbol = symbol;
            Data = data;
            SubNodes = new Dictionary<char, Node<T>>();
            Prefix = prefix;
        }

        public Node(string key, T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return $"{Data} [{SubNodes.Count}] {Prefix}";
        }

        public Node<T> TryFind(char symbol)
        {
            if (SubNodes.TryGetValue(symbol, out Node<T> value))
            {
                return value;
            }
            return null;
        }

        public override bool Equals(object obj)
        {
            if (obj is Node<T> item)
                return Data.Equals(item);
            return false;
        }
    }
}
