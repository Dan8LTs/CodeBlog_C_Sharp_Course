using Queue.Model;
using System;

namespace Queue_Deque
{
    public class Program
    {
        static void Main(string[] args)
        {
            var duplexDeque = new DuplexDeque<int>();
            duplexDeque.PushF(3);
            duplexDeque.PushF(5);
            duplexDeque.PushF(2);
            duplexDeque.PushB(9);
            duplexDeque.PushB(8);

            Console.WriteLine("duplexDeque");
            Console.WriteLine(duplexDeque.PopF());
            Console.WriteLine(duplexDeque.PopB());
            Console.WriteLine(duplexDeque.PopF());
            Console.WriteLine(duplexDeque.PopF());
            Console.ReadKey();

            var firstDeque = new FirstDeque<int>();
            firstDeque.PushF(3);
            firstDeque.PushF(5);
            firstDeque.PushF(2);
            firstDeque.PushB(9);
            firstDeque.PushB(8);

            Console.WriteLine();
            Console.WriteLine("firstDeque");
            Console.WriteLine(firstDeque.PopF());
            Console.WriteLine(firstDeque.PopB());
            Console.WriteLine(firstDeque.PopF());
            Console.WriteLine(firstDeque.PopF());
            Console.ReadKey();

            var linkedQueue = new LinkedQueue<int>();
            linkedQueue.Enqueue(3);
            linkedQueue.Enqueue(5);
            linkedQueue.Enqueue(2);
            linkedQueue.Enqueue(9);

            Console.WriteLine();
            Console.WriteLine("linkedDeque");
            Console.WriteLine(linkedQueue.Dequeue());
            Console.WriteLine(linkedQueue.Peek());
            Console.ReadKey();

            var arrayQueue = new ArrayQueue<int>(5);
            arrayQueue.Enqueue(3);
            arrayQueue.Enqueue(5);
            arrayQueue.Enqueue(2);
            arrayQueue.Enqueue(9);

            Console.WriteLine();
            Console.WriteLine("arrayQueue");
            Console.WriteLine(arrayQueue.Dequeue());
            Console.WriteLine(arrayQueue.Peek());
            Console.ReadKey();

            var firstQueue = new FirstQueue<int>();
            firstQueue.Enqueue(3);
            firstQueue.Enqueue(5);
            firstQueue.Enqueue(2);
            firstQueue.Enqueue(9);

            Console.WriteLine();
            Console.WriteLine("firstQueue");
            Console.WriteLine(firstQueue.Dequeue());
            Console.WriteLine(firstQueue.Peek());

            Console.ReadKey();
        }
    }
}
