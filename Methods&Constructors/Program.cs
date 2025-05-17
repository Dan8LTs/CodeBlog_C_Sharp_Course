using System.Diagnostics;

namespace Methods_Constructors
{
    internal sealed class BeforeFieldInit
    {
        public static int Value = 235;
    }
    internal sealed class Precise
    {
        public static int Value;
        static Precise()
        {
            Value = 235;
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            const int count = 1000000000;
            Test(count);
            Test(count);
        }

        private static void Test(int count)
        {
            BeforeFieldInit.Value = 0;
            Precise.Value = 0;

            var sw = Stopwatch.StartNew();
            for (int i = 0; i < count; i++)
            {
                Precise.Value = 1;
            }
            Console.WriteLine($"{sw.Elapsed} - Precise");

            sw = Stopwatch.StartNew();
            for (int i = 0; i < count; i++)
            {
                BeforeFieldInit.Value = 1;
            }
            Console.WriteLine($"{sw.Elapsed} - BeforeFieldInit");
        }
    }
}