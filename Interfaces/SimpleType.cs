namespace Interfaces
{
    internal class SimpleType : IDisposable
    {
        // неявная реализация метода
        public void Dispose()
        {
            Console.WriteLine("SimpleType Dispose()");
        }

        // явная реализация метода
        //void IDisposable.Dispose()
        //{
        //    Console.WriteLine("IDisposable Dispose()");
        //}
    }
}
