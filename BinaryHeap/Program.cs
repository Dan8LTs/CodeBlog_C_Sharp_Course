using System;
using System.Diagnostics;

namespace BinaryHeap
{
    public class Program
    {
        static void Main(string[] args)
        {
            var timer = new Stopwatch();
            var rnd = new Random();
            Console.WriteLine("Создание рандома\n" + timer.Elapsed);
            timer.Start();
            var heap = new Heap();
            for (int i = 0; i < 100; i++)
            {
                heap.Add(rnd.Next(-3356, 3356));
            }

            foreach (var item in heap)
            {
                Console.WriteLine(item);
            }
            timer.Stop();
            Console.WriteLine("На выполнение программы затрачено мс: " + timer.Elapsed.Milliseconds);
            Console.ReadKey();
        }
    }
}
