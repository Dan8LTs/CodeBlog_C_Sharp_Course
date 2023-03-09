using System;

namespace Map_dictionary_
{
    class Program
    {
        static void Main(string[] args)
        {
            var mMap = new ModifiedMap<int, string>();
            mMap.Add(new Item<int, string>(1, "One"));
            mMap.Add(new Item<int, string>(2, "Five"));
            mMap.Add(new Item<int, string>(2, "Five"));
            mMap.Add(new Item<int, string>(1324, "Ten"));
            mMap.Add(new Item<int, string>(5, "Fifteen"));
            foreach (var i in mMap)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(mMap.Search(6) ?? "Not found");
            Console.WriteLine(mMap.Search(5) ?? "Not found");

            mMap.Remove(1324);
            mMap.Remove(1);
            foreach (var i in mMap)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();

            var fMap = new FirstMap<int, string>();
            fMap.Add(new Item<int, string>(1, "One"));
            fMap.Add(new Item<int, string>(5, "Five"));
            fMap.Add(new Item<int, string>(10, "Ten"));
            fMap.Add(new Item<int, string>(15, "Fifteen"));

            foreach (var i in fMap)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(fMap.Search(6) ?? "Not found");
            Console.WriteLine(fMap.Search(5) ?? "Not found");

            fMap.Remove(10);
            fMap.Remove(1);
            foreach (var i in fMap)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
