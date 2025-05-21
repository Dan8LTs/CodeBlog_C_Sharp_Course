/*
    Инициализация параметра до вызова метода
• ref: параметр должен быть инициализирован до передачи в метод.
• out: параметр не обязательно должен быть инициализирован до передачи.

    Присвоения значения внутри метода
• ref: присваивать значение параметру внутри метода не обязательно.
• out: присваивать значение параметру внутри метода обязательно перед выходом из метода.

    Использование
• ref: используется, когда нужно передать переменную по ссылке и возможно использовать её текущее значение.
• out: используется, когда метод должен вернуть несколько значений через параметры (например, методы TryParse).

    Семантика
• ref: передача параметра по ссылке с возможностью чтения и записи.
• out: передача параметра по ссылке, который служит только для вывода данных из метода.
*/

namespace Parameters
{
    internal class Program
    {
        static int value = 0;
        static void Main(string[] args)
        {
            Method();
            Method(6, "B");
            Method(2, g: Guid.NewGuid(), dt: DateTime.Now);
            Method(value++, value++.ToString());
            Console.WriteLine(value);
            Method(s: (value++).ToString(), x: value++);
            Console.WriteLine(value);


            Console.WriteLine();


            GetValue(out int x);
            Console.WriteLine(x);

            int y = 8;
            AddValue(ref y);
            Console.WriteLine(y);


            Console.WriteLine();


            var dog = new Dog("Mandarinka");
            Console.WriteLine(dog);
            ChangeDogName(ref dog, "Persik");
            Console.WriteLine(dog);

            Dog dog2;
            CreateDog(out dog2);
            Console.WriteLine(dog2);


            Console.WriteLine();


            var s1 = "a";
            var s2 = "b";
            Console.WriteLine(s1 + s2);
            Swop(ref s1, ref s2);
            Console.WriteLine(s1 + s2);


            Console.WriteLine();


            Console.WriteLine(Sum(1, 2, 4, 8));
            DisplayTypes(4, "what", new Random(), 3.2, new Object(), new Action(Console.WriteLine));
        }
        static void Method(int x = 8, string s = "S", DateTime dt = default, Guid g = new Guid())
        {
            Console.WriteLine($"x = {x}, s = {s}, dt = {dt}, guid = {g}");
        }

        // private static void GetValue(ref int x) { }
        private static void GetValue(int x) { }
        private static void GetValue(out int v)
        {
            v = 1;
        }
        private static void AddValue(ref int v)
        {
            v += 1;
        }

        private static void CreateDog(out Dog dog)
        {
            dog = new Dog(Guid.NewGuid().ToString());
        }
        private static void ChangeDogName(ref Dog dog, string name)
        {
            dog.Name += "2";
            dog = new Dog(name);
            Console.WriteLine(dog);
        }

        private static void Swop<T>(ref T s1, ref T s2)
        {
            var temp = s2;
            s2 = s1;
            s1 = temp;
        }

        // [ParamArray]
        private static int Sum(params int[] values)
        {
            var res = 0;
            foreach (var v in values)
            {
                res += v;
            }
            return res;
        }
        // нужно делать перегрузки для оптимизации
        private static int Sum(int i1, int i2, int i3)
        {
            return i1 + i2 + i2;
        }
        private static void DisplayTypes(params object[] items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item.GetType());
            }
        }

        private static void BadMethod<T>(List<T> collection) { }
        // более универсальный метод
        private static void GoodMethod<T>(IEnumerable<T> collection) { }


        private static Stream BadMethod() { return null; }
        // для возвращаемого значения нужно выбирать более специфичный тип
        private static FileStream GoodMethod() { return null; }
    }
}