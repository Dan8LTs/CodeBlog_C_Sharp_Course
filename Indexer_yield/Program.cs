using System;
using System.Collections.Generic;

namespace Indexer_yield
{
    class Program
    {
        static void Main(string[] args)
        {
            var houses = new List<House>()
        {
            new House() { Name = "JilComService", Number = "8" },
            new House() { Name = "MoscowCity", Number = "6" }
        };

            Street street = new Street();

            foreach (var house in houses)
            {
                street.Add(house);
            }

            foreach (var house in street)
            {
                Console.WriteLine(house);
            }

            foreach (var item in street)
            {
                Console.WriteLine(item + " ");
            }

            foreach (var name in street.GetNames())
            {
                Console.WriteLine("name:" + name);
            }


            Console.WriteLine();
            Console.WriteLine(street["6"]?.Name);
            Console.WriteLine("Enter number of houses: ");
            var num = Console.ReadLine();

            street[1] = new House() { Name = "HouseCompany", Number = num };
            Console.WriteLine(street[1]);
            Console.ReadKey();
        }
    }
}
