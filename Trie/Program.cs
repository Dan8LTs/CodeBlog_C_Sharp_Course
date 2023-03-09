using System;

namespace Trie
{
    public class Program
    {
        static void Main(string[] args)
        {
            var trie = new Trie<int>();
            trie.Add("Hello!", 44);
            trie.Add("World", 100);
            trie.Add("Prize", 128);
            trie.Add("Hero", 256);
            trie.Add("Premium", 32);

            trie.Delete("World");

            Search(trie, "Hello!");
            trie.Delete("Hello!");
            Search(trie, "Hello!");

            Console.ReadKey();
        }

        private static void Search(Trie<int> trie, string key)
        {
            if (trie.TrySearch(key, out int value))
            {
                Console.WriteLine(value);
            }
            else
            {
                Console.WriteLine("Not found.");
            }
        }
    }
}