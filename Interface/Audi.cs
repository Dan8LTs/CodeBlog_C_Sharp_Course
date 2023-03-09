using System;

namespace Interface
{
    class Audi : ICar
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        public int Move(int distance)
        {
            return distance / 85;

        }
    }
}
