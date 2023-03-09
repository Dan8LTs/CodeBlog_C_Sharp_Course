using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {

            var collection = new List<Product>();

            for (var i = 0; i < 10; i++)
            {
                var product = new Product()
                {
                    Name = "Product" + i,
                    Energy = rnd.Next(10, 500)
                };
                collection.Add(product);
            }

            var result = from item in collection
                         where item.Energy < 200 || item.Energy > 300
                         // select - преобразование
                         select item;

            //var result2 = collection.Where(item => item < 5).
            //                         Where(item => item % 2 == 0).
            //                         OrderByDescending(item => item);

            foreach (var item in result)
            #region
            {
                Console.WriteLine(item);
            }
            #endregion
            Console.WriteLine();
            #region NotUse
            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            var selectCollection = collection.Select(product => product.Energy);
            foreach (var item in selectCollection)
            {
                Console.WriteLine(item);
            }

            var orderbyCollection = collection.OrderBy(product => product.Energy)
                                              .ThenByDescending(product => product.Name);
            foreach (var item in orderbyCollection)
            {
                Console.WriteLine(item);
            }

            var groupbyCollection = collection.GroupBy(product => product.Energy);
            foreach (var group in groupbyCollection)
            {
                Console.WriteLine($"Key: {group.Key}");
                foreach (var item in group)
                {
                    Console.WriteLine($"\t {item}");
                }
            }

            collection.Reverse();
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(collection.All(item => item.Energy == 10));
            Console.WriteLine(collection.Any(item => item.Energy == 10));
            Console.WriteLine(collection.Contains(collection[5]));

            var produ = new Product();
            Console.WriteLine(collection.Contains(produ));

            var array = new int[] { 1, 3, 2, 5 };
            //TODO: copy numbers in massive 
            var union = array.Union(array);
            foreach (var item in union)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            var array2 = new int[] { 6, 3, 1, 4 };
            //TODO: вычитаем из 2 массива 1-й
            var intersect = array.Intersect(array2);
            foreach (var item in intersect)
            {
                Console.WriteLine(item);
            }

            var except = array.Except(array2);
            foreach (var item in except)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            var sum = array.Sum();
            var min = collection.Min(p => p.Energy);
            var max = collection.Max(p => p.Energy);
            var aggregate = array.Aggregate((x, y) => x * y);

            //TODO: skip - пропуск элементов(кол-во), take - сколько элементов взять
            var sum2 = array.Skip(1).Take(2).Sum();

            var first = collection.FirstOrDefault(product => product.Energy == 10);
            var last = array.LastOrDefault();
            var elementAt = collection.ElementAt(5);
            Console.ReadKey();
        }
    }
}
