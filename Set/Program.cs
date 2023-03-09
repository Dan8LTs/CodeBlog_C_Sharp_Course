using Set.Model;
using System;
using System.Collections.Generic;

namespace Set
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> l1 = new List<int>();
            l1.Add(1);
            l1.Add(3);
            l1.Add(5);
            l1.Add(7);
            l1.Add(9);
            List<int> l2 = new List<int>();
            l1.Add(3);
            l1.Add(4);
            l1.Add(6);
            l1.Add(8);
            l1.Add(10);
            List<int> l3 = new List<int>();
            l1.Add(5);
            l1.Add(7);
            l1.Add(9);


            var fSet1 = new FirstSet<int>(l1);
            var fSet2 = new FirstSet<int>(l2);
            var fSet3 = new FirstSet<int>(l3);

            Console.WriteLine("Union: ");
            foreach (var i in fSet1.Union(fSet2))
            {
                Console.WriteLine(i + " ");
            }

            Console.WriteLine("Intersection: ");
            foreach (var i in fSet1.Intersection(fSet2))
            {
                Console.WriteLine(i + " ");
            }

            Console.WriteLine("Difference A \\ B: ");
            foreach (var i in fSet1.Difference(fSet2))
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Difference B \\ A: ");
            foreach (var i in fSet2.Difference(fSet1))
            {
                Console.WriteLine(i + " ");
            }

            Console.WriteLine("A Subset C: ");
            Console.Write(fSet1.Subset(fSet3));
            Console.WriteLine();

            Console.WriteLine("C Subset A: ");
            Console.Write(fSet3.Subset(fSet1));
            Console.WriteLine();

            Console.WriteLine("C Subset B: ");
            Console.Write(fSet1.Subset(fSet3));
            Console.WriteLine();

            Console.WriteLine("Symmetric Difference: ");
            foreach (var i in fSet1.SymmetricDifference(fSet2))
            {
                Console.Write(i + " ");
            }

            Console.ReadLine();
        }
    }
}
