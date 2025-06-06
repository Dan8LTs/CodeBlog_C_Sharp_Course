namespace Interfaces
{
    internal struct SomeValueType : IComparable
    {
        public int Value { get; }
        public SomeValueType(int value)
        {
            Value = value;
        }
        public int CompareTo(object other)
        {
            return Math.Sign(Value - ((SomeValueType)other).Value);
        }
    }

    // недостатки: путаница в документации, упаковка
    internal struct EimiValueType : IComparable
    {
        public int Value { get; }
        public EimiValueType(int value)
        {
            Value = value;
        }
        public int CompareTo(EimiValueType other)
        {
            return Math.Sign(Value - other.Value);
        }
        int IComparable.CompareTo(object? other)
        {
            return CompareTo((EimiValueType)other);
        }
    }
}
