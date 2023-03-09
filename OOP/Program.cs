using System;

namespace OOП
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Данил";
            person.LastName = "Маскин";

            Person p2 = new Person();
            p2.FirstName = "Григорий";
            p2.LastName = "Смирнов";

            var p = new Programmer();
            p.Specialisation = "C#";
            p.FirstName = "Антон";
            p.LastName = "Пресняков";

            Console.WriteLine(p.FirstName);
            Console.WriteLine(p.Specialisation);

            Person d = p;
            Console.WriteLine(p.LastName);
            Programmer dd = (Programmer)p;

            Console.WriteLine(dd.FirstName);
            Console.WriteLine(dd.Specialisation);
            Console.ReadKey();
        }
    }
}
