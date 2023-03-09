using System;

namespace Interface
{
    public class Cyberg : ICar, IPerson
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        int ICar.Move(int distance)
        {
            return distance / 100;
        }

        int IPerson.Move(int distance)
        {
            return distance / 5;
        }
    }
}
