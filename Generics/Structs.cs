namespace Generics
{
    internal struct Struct1 : Interface1<int>
    {
        public int GetT()
        {
            return default;
        }
    }

    internal struct Struct2 : Interface1<int>
    {
        public int GetT()
        {
            return default;
        }
    }
}