using System;
using System.Collections.Generic;
using System.Linq;

namespace Anonymous_Method__Lambda_Expressions
{
    class Program
    {
        public delegate int MyHandler(int i);
        static void Main(string[] args)
        {
            var lesson = new Lesson("Programming C#");
            lesson.Started += (sender, date) =>
            {
                Console.WriteLine(sender);
                Console.WriteLine(date);
            };
            lesson.Start();

            var list = new List<int>();
            for (int i = 0; i <= 10; i++)
            {
                list.Add(i);
            }
            var res = list.Aggregate((x, y) => x + y);
            Console.WriteLine(res);

            var result1 = Agr(list, delegate (int i)
            {
                var r = i * i;
                Console.WriteLine(r);
                return r;
            });
            var result2 = Agr(list, Method);
            var result3 = Agr(list, x => x * x * x / 2);

            if (int.TryParse(Console.ReadLine(), out int result))
            {
                MyHandler handler = delegate (int i)
                {
                    var r = i * i / i;
                    Console.WriteLine(r);
                    return r;
                };
                handler += Method;
                handler(result);

                MyHandler lambdaHandler = (i) =>
                {
                    var r = i * i;
                    Console.WriteLine(r);
                    return r;
                };
                lambdaHandler(99);
            }
            else
            {
                throw new ArgumentNullException("Take int number");
            }

            Console.ReadLine();
            Method(88);
        }
        public static int Agr(List<int> list, MyHandler handler)
        {
            int result = 0;
            foreach (var item in list)
            {
                result += handler(item);
            }
            return result;
        }

        public static int Method(int i)
        {
            var res = i * i * i;
            Console.WriteLine(res);
            return res;
        }
    }
}
