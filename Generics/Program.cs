using DateTimeList = System.Collections.Generic.List<System.DateTime>;

namespace Generics
{
    public delegate TResult Fnc<in T, out TResult>(T arg);
    public delegate TResult Dlg<in TArg, out TResult, TStandard>(TArg arg);
    // TArg - контрвариантный (любой из базовых),
    // TResult - ковариантный (любой из наследников),
    // TStandart - инвариантный (только данный)

    class Base { }
    class Child : Base { }
    class GrandChild : Child { }

    internal class Program()
    {
        public static void Main(string[] args)
        {
            const int Count = 100000000;
            if (Console.ReadKey().Key == ConsoleKey.D1)
            {
                Console.WriteLine();
                Tests.ValueTypePerf(Count);
                Tests.ReferenceTypePerf(Count);
            }


            object o = null;
            Type t = typeof(Dictionary<,>); // Dictionary<,> - открытый тип с двумя параметрами типа
            o = CreateInstance(t);
            t = typeof(DictionaryStringKey<>); // DictionaryStringKey<> - открытый тип с одним параметром типа
            o = CreateInstance(t);
            t = typeof(DictionaryStringKey<Guid>); // DictionaryStringKey<Guid> - закрытый тип
            o = CreateInstance(t);
            Console.WriteLine("Object type=" + o.GetType());


            Console.WriteLine();


            Node head = new TypedNode<char>('.');
            head = new TypedNode<DateTime>(DateTime.Now, head);
            head = new TypedNode<string>("Hello, World", head);
            Console.WriteLine(head.ToString());


            Fnc<object, ArgumentException> fn1 = null;
            Fnc<string, Exception> fn2 = fn1;
            //Exception e = fn2("");


            IEnumerable<DateTime> dates = new List<DateTime> { DateTime.Now, DateTime.UtcNow };
            ProcessCollection(dates);
            IEnumerable<string> strings = ["What", "How"];
            ProcessCollection(strings);


            Console.WriteLine();


            int n1 = 1, n2 = 2;
            Console.WriteLine($"{n1} {n2}");
            Swap(ref n1, ref n2);
            Console.WriteLine($"{n1} {n2}");

            string s1 = "Medium", s2 = "Rare";
            Console.WriteLine($"{s1} {s2}");
            Swap(ref s1, ref s2);
            Console.WriteLine($"{s1} {s2}");


            Console.WriteLine();


            MethodTakingAnyType(8);
            MethodTakingAnyType("xyz");


            Console.WriteLine();


            var p = new P<bool, bool>();
            Console.WriteLine(p.Get(true));
            var pp = new PP<int>();
            Console.WriteLine(pp.Get(0));


            Console.WriteLine();


            Console.WriteLine(typeof(List<Dictionary<Dictionary<int, string>, Dictionary<char, Stream>>>) == typeof(Dich));
            Console.WriteLine(typeof(List<DateTime>) == typeof(DateTimeList));


            var st1 = new Struct1();
            var st2 = new Struct2();
            var list = new List<Interface1<int>>();
            list.Add(st1); // boxing
            list.Add(st2); // boxing


            Dlg<Child, Child, Child> item1 = null;
            Dlg<Base, GrandChild, Child> item2 = null;
            item1 = item2;


            var item = new Class3<int>();
            item.Method(8, "me");


            Console.WriteLine();


            Console.WriteLine(Min(3.14, 12));
            Inheritor(new Child(), new Base());
        }

        // тип T должен реализовывать интерфейc IComparable
        private static T Min<T>(T v1, T v2) where T : IComparable<T>
        {
            if (v1.CompareTo(v2) < 0) return v1;
            return v2;
        }

        private static void Inheritor<T1, T2>(T1 t1, T2 t2) where T1 : T2 => Console.WriteLine($"{typeof(T1)} is an inheritor of {typeof(T2)}");

        private static void MethodTakingAnyType<T>(T v)
        {
            Console.WriteLine(v.ToString().ToUpper());
        }

        private static void Swap<T>(ref T o1, ref T o2)
        {
            Console.WriteLine("Generic swap");
            T temp = o1;
            o1 = o2;
            o2 = temp;
        }

        private static void Swap(ref int o1, ref int o2)
        {
            Console.WriteLine("Usual swap");
            int temp = o1;
            o1 = o2;
            o2 = temp;
        }

        private static void ProcessCollection<T>(IEnumerable<T> collection) { }

        private static object? CreateInstance(Type t)
        {
            object o = null;
            try
            {
                o = Activator.CreateInstance(t);
                Console.WriteLine($"Created instance of {t.ToString()}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            return o;
        }

        internal class Dich : List<Dictionary<Dictionary<int, string>, Dictionary<char, Stream>>> { }
    }
}