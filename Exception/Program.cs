using System;

namespace exception
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine();

                if (int.TryParse(input, out int result))
                {
                    Console.WriteLine($"Int {result}");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect, take number INT");
                }
            }

            int i = 0;
            try
            {
                Console.WriteLine(5 / i);
                throw new MyException();
                //throw new ArgumentNullException("i", "gdfgdfg");
                //throw new DivideByZeroException("i != 5");
            }
            catch (MyException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex) when (i == 0)
            {
                Console.WriteLine("on 0");

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception");

            }
            finally
            {
                Console.WriteLine("Work exited");
                Console.ReadLine();
            }
        }
    }
}
