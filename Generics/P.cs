namespace Generics
{
    internal class P<TKey, TValue>
    {
        TKey i;
        public TValue Get(TKey key)
        {
            return default;
        }
    }
    internal class PP<TValue> : P<int, TValue> { }
}
