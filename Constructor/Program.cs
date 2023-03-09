using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var sname = Console.ReadLine();
            Person p = new Person(name, sname);
            Console.WriteLine(p.Name);
            Console.WriteLine(p.SecondName);
            //Person p = new Person();
            //p.Name = "Vasya";
            //p.SecondName = "Stanin";
            //Console.WriteLine(p.FullName);
            //Console.WriteLine(p.ShortName);
            Console.ReadKey();
        }
    }
}
