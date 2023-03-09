namespace Generic
{
    public class Product
    {
        public int Weight { get; set; }
        public int Energy { get; set; }

        public Product(int weight, int energy)
        {
            Weight = weight;
            Energy = energy;
        }
    }
}
