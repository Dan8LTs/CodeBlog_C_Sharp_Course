using Stack.Model;
using System;

namespace Stack
{
    public class Program
    {
        static void Main(string[] args)
        {
            var easyStack = new Stack1<int>();

            easyStack.Push(324);
            easyStack.Push(123);
            easyStack.Push(353);

            var item = easyStack.Pop();
            var item2 = easyStack.Peek();

            Console.WriteLine(item);
            Console.WriteLine(item2);
            Console.ReadKey();

            var linkedStack = new LinkedStack<int>();
            linkedStack.Push(324);
            linkedStack.Push(544);
            linkedStack.Push(454);
            linkedStack.Push(329);
            linkedStack.Push(108);

            Console.WriteLine(linkedStack.Peek());
            Console.WriteLine(linkedStack.Pop());
            Console.WriteLine(linkedStack.Pop());
            Console.WriteLine(linkedStack.Peek());
            Console.ReadKey();

            var arrayStack = new ArrayStack<int>(6);
            arrayStack.Push(111);
            Console.WriteLine(arrayStack.Count);
            arrayStack.Push(222);
            arrayStack.Push(333);
            arrayStack.Push(444);
            arrayStack.Push(555);
            arrayStack.Push(888);

            Console.WriteLine(arrayStack.Peek());
            Console.WriteLine(arrayStack.Pop());
            Console.ReadLine();
        }
    }
}
