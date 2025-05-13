namespace Polymorphism
{
    internal class ClosedClass
    {
        public sealed override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
        public sealed override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public sealed override string ToString()
        {
            return base.ToString();
        }
        // NOT protected or virtual
    }
}
