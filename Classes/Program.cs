using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Smartphone smartphone1 = new Smartphone("lenovo", 7, 600);
            Smartphone smartphone2 = new Smartphone("samsung", 9, 900);
            var sumsmartphone = smartphone1 + smartphone2;
            Console.WriteLine(smartphone1);
            Console.WriteLine(smartphone2);
            Console.WriteLine(sumsmartphone);

            Console.ReadKey();
        }
    }
}
