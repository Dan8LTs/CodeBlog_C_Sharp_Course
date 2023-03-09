using System;

namespace Methods
{
    public class Personb
    {
        public string SecondName { get; set; }
        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Personb(string secondName, string name)
        {
            SecondName = secondName;
            Name = name;

            X = 0;
            Y = 0;
        }
        public string Run()
        {
            var rnd = new Random();
            X += rnd.Next(-2, 2);
            Y += rnd.Next(-2, 2);

            return $"{Name}({X},{Y})";
        }
        public string Run(int x, int y)
        {
            x += x;
            y += y;
            return $"{Name}({X},{Y})";
        }
    }
}
