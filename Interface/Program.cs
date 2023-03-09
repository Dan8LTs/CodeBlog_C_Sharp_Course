using System;
using System.Collections.Generic;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<ICar>();
            cars.Add(new MBGLE());
            cars.Add(new Audi());

            foreach (var car in cars)
            {
                Console.WriteLine(car.Move(200));

            }

            Cyberg cyberg = new Cyberg();
            Console.WriteLine(((ICar)cyberg).Move(100));
            Console.WriteLine(((IPerson)cyberg).Move(100));
            Console.ReadKey();
        }
    }
}
