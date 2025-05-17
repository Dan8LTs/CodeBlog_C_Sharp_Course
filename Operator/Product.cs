using System;

namespace @operator
{
    //нельзя создать экземпляр
    public abstract class Product
    {
        public string Name { get; }

        public int Calorie { get; }

        public int Volume { get; set; }

        public double Energy
        {
            get
            {
                return Volume * Calorie / 100.0;
            }
        }
        public Product(string name, int calorie, int volume)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (calorie < 0)
            {
                throw new ArgumentNullException(nameof(calorie));
            }
            if (volume <= 0)
            {
                throw new ArgumentNullException(nameof(volume));
            }
            Name = name;
            Calorie = calorie;
            Volume = volume;
        }
        public override string ToString()
        {
            return $"{Name}. Калорийность: {Calorie}. Объем: {Volume}.";
        }
    }
}
