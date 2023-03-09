using System;

namespace Interface
{
    class MBGLE : ICar, IDisposable
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public int Move(int distance)
        {
            return distance / 100;
        }
    }
}
