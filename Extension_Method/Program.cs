using System;
using System.Collections.Generic;

namespace Extension_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Take a number: ");
            var input = Console.ReadLine();

            if (int.TryParse(input, out int result))
            {

                if (result.IsEven())
                {
                    Console.WriteLine($"{result} is even");
                }
                else
                {
                    Console.WriteLine($"{result} is not even");
                }
                int h = 182;
                172.isDividedBy(7);

                var list = new List<House>();
            }
            else
            {
                Console.WriteLine("TAKE THE INT NUMBER");
            }
            var houses = new List<House>();
            for (var i = 0; i < 10; i++)
            {
                var house = new House();
                house.CreateRndHouse(1000, 10000);
                houses.Add(house);
            }

            foreach (var house in houses)
            {
                Console.WriteLine(house.Number.ToString() + " " + house.Height);
            }
            Console.ReadKey();
        }
    }
}
