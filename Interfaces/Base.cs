namespace Interfaces
{
    internal class Base : IComparable
    {
        int IComparable.CompareTo(object? obj)
        {
            Console.WriteLine("Base CompareTo()");
            return CompareTo(obj);
        }
        public virtual int CompareTo(object? obj)
        {
            Console.WriteLine("Base virtual CompareTo()");
            return 0;
        }
    }

    internal class Derived : Base
    {
        public override int CompareTo(object? obj)
        {
            Console.WriteLine("Derived CompareTo()");
            return base.CompareTo(obj);
        }
    }
}
