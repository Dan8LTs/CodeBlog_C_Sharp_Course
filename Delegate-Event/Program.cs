using System;

namespace delegate_events
{
    class Program
    {
        public delegate void MyDelegate();
        public delegate int ValueDelegate(int i);
        public Action ActionDelegate;
        public delegate int Func(string value);
        public event MyDelegate Event;
        public event Action EventAction;
        static void Main(string[] args)
        {
            #region delegate
            MyDelegate myDelegate = Method1;
            myDelegate += Method3;
            myDelegate();

            MyDelegate myDelegate2 = new MyDelegate(Method4);
            myDelegate2 += Method1;
            myDelegate2.Invoke();

            MyDelegate myDelegate3 = myDelegate + myDelegate2;
            myDelegate3();

            var valueDelegate = new ValueDelegate(MethodValue);
            valueDelegate += MethodValue;
            valueDelegate(new Random().Next(10, 100));

            Action action = Method1;
            action();

            Predicate<int> predicate;


            Func<int, int> func = MethodValue;
            //if(func != null)
            //    func(7);
            func?.Invoke(7);
            Console.ReadKey();
            #endregion
            Person person = new Person();
            person.Name = "Tolya";
            person.GoToSleep += Person_GoToSleep;
            person.DoWork += Person_DoWork;
            person.TakeTime(DateTime.Parse("07.11.2019 23:21:40"));
            person.TakeTime(DateTime.Parse("07.11.2019 7:13:24"));
        }

        private static void Person_DoWork(object sender, EventArgs e)
        {
            if (sender is Person)
            {
                // sender - отправитель
                Console.WriteLine($"{((Person)sender).Name} do work");
            }
        }

        // action --
        private static void Person_GoToSleep()
        {
            Console.WriteLine("Person went to bed");
            Console.ReadKey();
        }
        public static int MethodValue(int i)
        {
            Console.WriteLine(i);
            return i;
        }

        public static void Method1()
        {
            Console.WriteLine("MethodOne");
        }
        public static int Method2()
        {
            Console.WriteLine("MethodTwo");
            return 0;
        }
        public static void Method3()
        {
            Console.WriteLine("MethodThree");
        }
        public static void Method4()
        {
            Console.WriteLine("MethodFour");
        }
    }
}