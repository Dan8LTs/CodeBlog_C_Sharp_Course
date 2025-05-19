namespace Parameters
{
    class Program
    {
        static int value = 0;
        static void Main(string[] args)
        {
            Method();
            Method(6, "B");
            Method(2, g: Guid.NewGuid(), dt: DateTime.Now);
            Method(value++, value++.ToString());
            Console.WriteLine(value);
            Method(s: (value++).ToString(), x: value++);
            Console.WriteLine(value);
        }
        static void Method(int x = 8, string s = "S", DateTime dt = default, Guid g = new Guid())
        {
            Console.WriteLine($"x = {x}, s = {s}, dt = {dt}, guid = {g}");
        }
    }
}