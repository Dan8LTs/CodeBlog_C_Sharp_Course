using System;

namespace Anonymous_Type__Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 5;

            var product = new
            {
                Name = "Milk",
                Energy = 10
            };

            Console.WriteLine(product);
            Console.WriteLine(product.Energy);
            Console.WriteLine(product.Name);

            var eat = new Eat()
            {
                Name = "Meat"
            };

            var product2 = new
            {
                eat.Name,
                Energy = 200
            };

            Console.WriteLine(product2);


            Tuple<int, string> tuple = new Tuple<int, string>(5, "Hello!");
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item2);
            //need NuGet 
            var tuple2 = (5, "Hello!");
            var tuple3 = (Name: "Tomato", Energy: 20);
            tuple3.Energy = 60;

            var result = GetData();
            Console.WriteLine(result);
            Console.ReadKey();
        }
        public static (int, string, bool) GetData()
        {
            var number = 9759;
            var name = Guid.NewGuid().ToString();
            bool b = number > 500;

            return (number, name, b);
        }
    }
}
