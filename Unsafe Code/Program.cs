using System;

namespace Unsafe_Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Неуправляемый код. Не относится к платформе CLR. Позволяет вручную изменять и считывать значения из ячеек памяти.
            unsafe
            {
                int i = 48;

                // Адрес первой ячейки, занимаемой данными переменной i.
                int* address = &i;

                Console.WriteLine((long)address);
                Console.WriteLine(*address);
                Console.WriteLine();

                int a = 6;
                int b = 7;
                Calc(a, &b);
                Console.WriteLine(a + " " + b);

                b = 7;
                Calc2(a, ref b);
                Console.WriteLine(a + " " + b);

                int* address2 = address - 12;
                Console.WriteLine(*address2);
                Console.WriteLine();

                // Указатель на указатель.
                int** adr = &address;
                Console.WriteLine((long)adr);
                Console.WriteLine((long)*adr);
                Console.WriteLine(**adr);

                Console.ReadKey();
                Console.WriteLine("__________________________");
                int f = 0;
                while (f != 1000)
                {
                    Console.WriteLine(*(address + f));
                    f++;
                }
                Console.ReadKey();
            }
        }

        static unsafe void Calc(int i, int* j)
        {
            i = 400;
            *j = 800;
        }

        static void Calc2(int i, ref int j)
        {
            i = 400;
            j = 800;
        }
    }
}
