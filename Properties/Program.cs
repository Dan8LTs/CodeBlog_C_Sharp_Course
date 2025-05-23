namespace Properties
{
    internal class Program()
    {
        static void Main(string[] args)
        {
            var p1 = new Person();
            p1.SetName("Vlad");
            Console.WriteLine(p1.GetName());

            // обращение не к полю, а к методу - аксессору
            p1.Age = 19;
            p1.Profession = "sportsman";

            Console.WriteLine(p1.Age);
            Console.WriteLine(p1.YearOfBirth);
            Console.WriteLine(p1.Profession);

            var count = 14;
            var ba = new BitArray(count);
            for (int i = 0; i < count; i++)
            {
                ba[i] = (i % 2 == 0);
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Bit {i} is {(ba[i] ? "On" : "Off")}.");
            }

            // инициализатор объекта
            Person p2 = new Person("Maxim") { Age = 42, Profession = "mathematician" };
            var p3 = new Person("George");
            Console.WriteLine(p3);

            // лучше использовать AddRange для оптимизации
            var community = new Community()
            //community.People.Add(new Person("Artak"));
            //community.People.Add(new Person("Vadim"));
            {
                People =
                {
                    new Person("Artak"),
                    new Person("Vadim" )
                }
            };

            foreach (var person in community.People)
            {
                Console.WriteLine(person);
            }

            var dict = new Dictionary<string, int>
            {
                { "Michael", 19 },
                { "Zahar", 26 }
            };

            var dict2 = new Dictionary<string, int>();
            dict2.Add("Eugene", 14);
        }
    }
}