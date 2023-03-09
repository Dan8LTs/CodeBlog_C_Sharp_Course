using System;

namespace BST
{
    public class Program
    {
        static void Main(string[] args)
        {
            var tree = new BinaryTree<int>();
            tree.Add(6);
            tree.Add(5);
            tree.Add(8);
            tree.Add(3);
            tree.Add(2);
            tree.Add(4);
            tree.Add(0);

            foreach (var item in tree.Preorder())
            {
                Console.Write(item);
            }
            Console.WriteLine();
            Console.ReadKey();
            foreach (var item in tree.Postorder())
            {
                Console.Write(item);
            }
            Console.WriteLine();
            Console.ReadKey();
            foreach (var item in tree.Inorder())
            {
                Console.Write(item);
            }
            Console.ReadKey();
        }
    }
}
