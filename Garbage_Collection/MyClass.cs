using System;

namespace Garbage_Collection
{
    class MyClass : IDisposable
    {
        public MyClass() { }

        ~MyClass() { }

        public void Dispose()
        {
            GC.Collect();
        }
    }
}
