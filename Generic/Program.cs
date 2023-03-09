using System;
using System.Collections.Generic;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            var eating = new Eating<Product>();

            var orange = new Orange(120, 2);
            var apple = new Apple(12, 4);
            eating.Add(orange);
            eating.Add(apple);

            Console.WriteLine(eating.Volume);

            var list = new List<int>();
            var map = new Dictionary<string, string>();
            map.Add("5", "Five");

            Console.ReadKey();
        }
    }
}
