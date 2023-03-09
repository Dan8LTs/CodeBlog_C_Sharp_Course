using Linked_list.Model;
using System;

namespace Linked_list
{
    public class Program
    {
        static void Main(string[] args)
        {
            var circularList = new CircularDuplexList<int>();
            circularList.Add(1);
            circularList.Add(2);
            circularList.Add(3);
            circularList.Add(4);
            circularList.Add(5);
            circularList.Add(6);

            circularList.Delete(2);
            foreach (var item in circularList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            var duplexList = new DuplexList<int>();
            duplexList.Add(9);
            duplexList.Add(7);
            duplexList.Add(5);
            duplexList.Add(3);
            duplexList.Add(1);

            foreach (var item in duplexList)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();

            var list = new Model.List<double>
            {
                1.1,
                1.3,
                1.2
            };

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            list.Delete(1.2);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            list.AppendHead(5);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            list.InsertAfter(1.1, 6);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
