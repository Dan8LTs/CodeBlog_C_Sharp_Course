using System;

namespace Object
{
    class Program
    {
        static void Main(string[] args)
        {
            // Equals - ?= значения объектов
            // ReferenceEquals - ?= ссылки на объекты
            // Клон - дополнительный скопированный объект, содержащий эти же поля

            object obj = new object();

            int i = 6;
            int j = 6;

            Console.WriteLine(i.Equals(j));

            var oi = (object)i;
            object oj = j;
            Console.WriteLine(oi.Equals(oj));

            var p1 = new Point() { X = 5 };
            var p2 = new Point() { X = 5 };
            Console.WriteLine(p1.Equals(p2));
            Console.WriteLine(null == null);

            Console.WriteLine(i.GetHashCode());
            Console.WriteLine(oi.GetHashCode());
            Console.WriteLine(p1.GetHashCode());

            Console.WriteLine(i.ToString());
            Console.WriteLine(p1.ToString());

            Console.WriteLine(i.GetType());
            Console.WriteLine(oi.GetType());
            Console.WriteLine(p1.GetType());

            Console.WriteLine(typeof(Point) == p1.GetType());

            var pp = new Point() { X = 7, Y = new Point() };
            var pp2 = pp;
            pp2.X = 77;
            pp2.Y = new Point() { X = 99 };
            Console.WriteLine(pp);
            Console.WriteLine(pp.Y);
            var pp3 = pp.Clone();
            pp3.X = 88;
            pp3.Y.X = 222;
            Console.WriteLine(pp);
            Console.WriteLine(pp.Y);
            Console.ReadKey();
        }
    }
}
