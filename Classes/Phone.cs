using System;
namespace classes
{
    public abstract class Phone
    {
        public string Name { get; }
        public int Power { get; }
        public int Price { get; set; }



        public Phone(string name, int power, int price)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (power < 1)
            {
                throw new ArgumentNullException(nameof(power));
            }
            if (price <= 0)
            {
                throw new ArgumentNullException(nameof(price));
            }

            Name = name;
            Power = power;
            Price = price;

        }
        public override string ToString()
        {
            return $"{Name}. Power: {Power}. Price: {Price}.";
        }
    }
}

