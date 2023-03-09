namespace Generic
{
    public class Eating<T>
        where T : Product
    {
        public int Volume { get; private set; }

        public void Add(T product)
        {
            Volume += product.Weight * product.Energy;
        }
    }
}
