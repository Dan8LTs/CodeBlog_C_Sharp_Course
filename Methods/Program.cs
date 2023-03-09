using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //var person1 = new Personb("Semenov", "Jenya");
            //var person2 = new Personb("Code", "Blog");
            //for (var i = 0; i < 10; i++)
            //{
            //    var position1 = person1.Run();
            //    Console.WriteLine(position1);
            //    Console.WriteLine();
            //    //Console.WriteLine(person2.Run(1,2));
            //}
            Console.WriteLine(Factorial(Convert.ToInt32(Console.ReadLine())));
            Console.ReadLine();
        }
        public static int Factorial(int value)
        {
            if (value <= 1)
            {
                return 1;
            }
            else
            {
                return value * Factorial(value - 1);
            }
        }
    }
}
