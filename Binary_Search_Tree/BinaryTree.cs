using System;
using System.Collections.Generic;

namespace BST
{
    public class BinaryTree<T>
        where T : IComparable, IComparable<T>
    {
        public Node<T> Root { get; private set; }
        public int Count { get; private set; }
        public void Add(T data)
        {
            if (Root == null)
            {
                Root = new Node<T>(data);
                Count = 1;
                return;
            }
            Root.Add(data);
            Count++;
        }
        public List<T> Preorder()
        {
            var list = new List<T>();
            if (Root == null)
            {
                return list;
            }
            return Preorder(Root);
        }
        public List<T> Postorder()
        {
            var list = new List<T>();
            if (Root == null)
            {
                return list;
            }
            return Postorder(Root);
        }
        public List<T> Inorder()
        {
            var list = new List<T>();
            if (Root == null)
            {
                return list;
            }
            return Inorder(Root);
        }
        private List<T> Preorder(Node<T> node)
        {
            var list = new List<T>();
            if (node != null)
            {
                list.Add(node.Data);
                if (node.Left != null)
                {
                    list.AddRange(Preorder(node.Left));
                }
                if (node.Right != null)
                {
                    list.AddRange(Preorder(node.Right));
                }
            }
            return list;
        }
        private List<T> Postorder(Node<T> node)
        {
            var list = new List<T>();
            if (node != null)
            {
                if (node.Left != null)
                {
                    list.AddRange(Postorder(node.Left));
                }
                if (node.Right != null)
                {
                    list.AddRange(Postorder(node.Right));
                }
                list.Add(node.Data);
            }
            return list;
        }
        private List<T> Inorder(Node<T> node)
        {
            var list = new List<T>();
            if (node != null)
            {
                if (node.Left != null)
                {
                    list.AddRange(Inorder(node.Left));
                }
                list.Add(node.Data);
                if (node.Right != null)
                {
                    list.AddRange(Inorder(node.Right));
                }
            }
            return list;
        }
    }
}
