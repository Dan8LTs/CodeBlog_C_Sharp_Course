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
            Console.WriteLine(p1.Age);
            Console.WriteLine(p1.YearOfBirth);

            p1.Profession = "sportsman";
            Console.WriteLine(p1.Profession);
        }
    }
}