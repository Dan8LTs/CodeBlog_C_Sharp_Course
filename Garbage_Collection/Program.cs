using System;

namespace Garbage_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               //dispose, finalizer
               IDispose
               ITVDN
               Типы данных:
               Stack - ограниченный отдел памяти(fast)
               Куча - неограниченный отдел памяти(slow)
               Сборщик мусора в зависимости сколько времени находится объектв куче, по 3 поколениям, удаляет неиспользуемые объекты.  
            */

            Console.WriteLine(GC.GetTotalMemory(false));
            for (int i = 0; i < 10000; i++)
            {
                var obj = (object)i;
                int j = (int)obj;
            }
            Console.WriteLine(GC.GetTotalMemory(false));


            using (var c = new MyClass())
            {
                c.Dispose();
            }
            Console.WriteLine(GC.GetTotalMemory(false));
            Console.ReadKey();
        }
    }
}
