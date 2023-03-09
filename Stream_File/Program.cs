using System;
using System.IO;
using System.Text;

namespace stream__file
{
    public class Program
    {
        static void Main(string[] args)
        {
            // open
            // прочитать / записать
            // close
            Console.OutputEncoding = Encoding.UTF8;
            using (var sw = new StreamWriter("test.txt", true, Encoding.UTF8))
            {
                sw.Write("Hello, c#");
            }
            using (var sw = new StreamReader("test.txt", Encoding.UTF8, true))
            {
                var text = sw.ReadToEnd();
                Console.WriteLine(text);
            }
            Console.ReadKey();
        }
    }
}
