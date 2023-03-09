using System;

namespace TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string example = "888";
            if (int.TryParse(example, out int result))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(result);
                Console.ReadKey();
            }
            int way = Convert.ToInt32(example);
            Console.WriteLine(way);
            Console.ReadKey();
            int way2 = Int32.Parse(example);
            Console.WriteLine(way);
            Console.ReadKey();
            //int noWay = (int)example;
            //Work only with numerical data type
        }
    }
}
