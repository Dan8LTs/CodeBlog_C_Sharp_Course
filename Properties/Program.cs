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


            Console.WriteLine();


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

            foreach (var person in community)
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


            Console.WriteLine();


            // анонимный тип
            var item = new { Name = "Detroit: become human", ReleaseYear = 2018 };
            // автоматически создаётся аксессор get, класс, приватные поля, методы GetHashCode(), ToString(), Equals() 
            // нельзя передавать аргументом

            Console.WriteLine($"Game 1: {item.Name}! Release year: {item.ReleaseYear}");

            string Author = "Dan8LTs";
            // экземпляры одного анонимного типа
            var report = new { Author, Text = "Bugs fixed", DateTime.Now.Year };
            var report2 = new { Author, Text = "Optimized", DateTime.Now.Year };
            var list = new[] { report, report2 };
            foreach (var el in list)
            {
                Console.WriteLine(el);
            }

            report = report2;
            Console.WriteLine(report.Equals(report2));
            Console.WriteLine(report.Author + " " + report.Text + " " + report.Year);
        }
    }
}