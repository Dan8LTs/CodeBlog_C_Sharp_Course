using System.Diagnostics;

namespace Generics
{
    internal class OperationTimer : IDisposable
    {
        private Stopwatch _stopwatch;
        private string _text;
        private int _collectionCount;

        public OperationTimer(string text)
        {
            PrepareForOperation();

            _text = text;
            _stopwatch = Stopwatch.StartNew();
            _collectionCount = GC.CollectionCount(0);
        }

        public void Dispose()
        {
            Console.WriteLine("{0} (GCs={1,3}) {2}", (_stopwatch.Elapsed), GC.CollectionCount(0) - _collectionCount, _text);
        }
        private static void PrepareForOperation()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}
