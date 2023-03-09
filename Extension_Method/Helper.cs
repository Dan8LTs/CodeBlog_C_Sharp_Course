using System;
using System.Collections;
using System.Linq;

namespace Extension_Method
{
    public static class Helper
    {
        public static bool IsEven(this int i)
        {
            return i % 2 == 0;
        }

        public static bool isDividedBy(this int i, int j)
        {
            return i % j == 0;
        }
        public static string ConvertToString<T>(this IEnumerable collection)
        {
            var result = "";

            foreach (var item in collection)
            {
                result += item.ToString() + ", ";
            }
            return result;
        }

        public static House CreateRndHouse(this House house, int min, int max)
        {
            var rnd = new Random(Guid.NewGuid().ToByteArray().Sum(x => x));
            house.Number = rnd.Next(1, 50);
            house.Height = rnd.Next(5, 90);
            return house;

        }
    }
}
