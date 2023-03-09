using System;

namespace @operator
{
    class Program
    {
        static void Main(string[] args)
        {
            var apple1 = new Apple("Red apple", 100, 100);
            var apple2 = new Apple("Green apple", 90, 110);
            var sumapple = Apple.Add(apple1, apple2);
            var sumapple3 = apple1 + apple2;
            var sumapple2 = apple1 + 100;

            Console.WriteLine(apple1);
            Console.WriteLine(apple2);
            Console.WriteLine(sumapple);
            Console.WriteLine(sumapple3);
            Console.WriteLine(sumapple2);
            Console.WriteLine(apple1 == apple2);
            Console.WriteLine(sumapple == sumapple2);
            Console.ReadLine();
        }

    }
}
