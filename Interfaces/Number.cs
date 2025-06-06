namespace Interfaces
{
    internal class Number : IComparable<int>, IComparable<string>
    {
        public int Value { get; }
        public Number(int value)
        {
            Value = value;
        }
        public int CompareTo(int other)
        {
            return Value.CompareTo(other);
        }
        public int CompareTo(string other)
        {
            return Value.CompareTo(int.Parse(other));
        }
    }
}
