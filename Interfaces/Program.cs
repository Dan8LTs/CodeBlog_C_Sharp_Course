namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // интерфейс - поименнованный набор сигнатур методов

            var points = new List<Point>
            {
                new Point(2, 5),
                new SuperPoint(4, 3)
            };
            points.Sort();
            points.ForEach(Console.WriteLine);


            Console.WriteLine();


            string s = "you & i";
            DisplayAllMethods(s);

            ICloneable cloneable = s;
            DisplayAllMethods(cloneable);

            IComparable comparable = s;
            DisplayAllMethods(comparable);


            Struct1 st1 = new Struct1();
            IComparable comparable1 = st1; // boxing

            SimpleType st = new SimpleType();
            st.Dispose();
            IDisposable disposable = st;
            disposable.Dispose();


            Boxing(1, 2);
            WithoutBoxing(1, 2);

            Console.WriteLine();

            var number = new Number(32);
            Console.WriteLine(number.CompareTo(12));
            Console.WriteLine(number.CompareTo("2"));
            IComparable<int> comparableInt = number;
            Console.WriteLine(comparableInt.CompareTo(32));
            IComparable<string> comparableString = number;
            Console.WriteLine(comparableString.CompareTo("21"));

            Method(8);
            Method(new Guid());


            Console.WriteLine();


            var pizzeria = new Pizzeria();
            pizzeria.GetMenu();
            IWindow window = pizzeria;
            window.GetMenu();
            ((IRestaurant)pizzeria).GetMenu();

            var shawarmaShop = new ShawarmaShop();
            ((IRestaurant)shawarmaShop).GetMenu();

            var burgerBar = new BurgerBar();
            ((IRestaurant)burgerBar).GetMenu();

            var sushiBar = new SushiBar();
            sushiBar.GetMenu();
            ((IRestaurant)sushiBar).GetMenu();


            Console.WriteLine();


            var value = new SomeValueType(0);
            object obj = null;
            Console.WriteLine(value.CompareTo(value)); //boxing
            //Console.WriteLine(value.CompareTo(obj)); -> runtime exception

            var evalue = new EimiValueType(0);
            Console.WriteLine(evalue.CompareTo(evalue));
            //Console.WriteLine(evalue.CompareTo(obj)); -> cannot convert

            IComparable comp = evalue; // first boxing
            Console.WriteLine(comp.CompareTo(evalue)); // second boxing
                                                       //Console.WriteLine(comp.CompareTo(obj)); -> runtime exception


            Console.WriteLine();


            /* выбор между базовым классом и интерфейсом:
            1) какой тип создаём (struct - интерфейс) 
            2) нужно множественное наследование - интерфейс
            3) если нужна базовая реализация методов - класс
            4) есть деление на сборки - класс
            */
            BaseClasses();
            Interfaces();
            // можно создать и интерфейс, и базовый класс, используя их в зависимости от реализации
        }

        static void DisplayAllMethods<T>(T variable)
        {
            var uniqueMethods = typeof(T).GetMethods().Select(m => m.Name).Distinct();
            Console.WriteLine($"Переменная типа {typeof(T)} (фактический тип {variable.GetType()}) содержит следующие методы:");
            foreach (var method in uniqueMethods)
            {
                Console.Write(method + " ");
            }
            Console.WriteLine("\n");
        }

        static void Boxing(int x, int y)
        {
            IComparable comparable = x;
            comparable.CompareTo(y); // boxing
            //comparable.CompareTo(""); -> runtime exception
        }
        static void WithoutBoxing(int x, int y)
        {
            IComparable<int> comparable = x;
            comparable.CompareTo(y); // IComparable<int>.CompareTo(int other)
        }

        static void Method<T>(T item) where T : IComparable, IConvertible
        {
            Console.WriteLine("Generic method");
        }
        static void Method(IComparable item) // boxing при работе со значимыми типами
        {
            Console.WriteLine("Method");
        }

        static void BaseClasses()
        {
            var animals = new List<AnimalBase>
            {
                new Cat(),
                new Dog()
            };
            animals.ForEach(Console.WriteLine);
        }

        static void Interfaces()
        {
            var figures = new List<IFigure>
            {
                new Circle(8),
                new Square(6)
            };
            figures.ForEach(p => Console.WriteLine($"{p.GetType()} имеет площадь {p.GetArea()}"));
        }
    }
}
