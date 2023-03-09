using System;

namespace Hash_Table
{
    public class Program
    {
        static void Main(string[] args)
        {
            var HashTable = new GoodHashtable<Car>(100);
            var car = new Car() { Model = "Mercedes-BenzGLE", Year = 2037, Category = 'B' };
            HashTable.Add(new Car() { Model = "Lada4X4", Year = 2017, Category = 'B' });
            HashTable.Add(new Car() { Model = "AudiA4", Year = 2027, Category = 'B' });
            HashTable.Add(car);

            Console.WriteLine(HashTable.Search(new Car() { Model = "AudiA4", Year = 2027, Category = 'B' }));
            Console.WriteLine(HashTable.Search(car));
            Console.ReadKey();

            var mHashTable = new ModifiedHashtable<int, string>(100);
            mHashTable.Add(236, "Just");
            mHashTable.Add(85, "Like");
            mHashTable.Add(234, "Forever");

            Console.WriteLine(mHashTable.Search(85, "Like"));
            Console.WriteLine(mHashTable.Search(235, "WhaT?"));
            Console.ReadKey();

            var fHashTable = new FirstHashtable<int>(100);
            fHashTable.Add(236);
            fHashTable.Add(85);
            fHashTable.Add(234);

            Console.WriteLine(fHashTable.Search(85));
            Console.WriteLine(fHashTable.Search(235));
            Console.ReadKey();
        }
    }
}
