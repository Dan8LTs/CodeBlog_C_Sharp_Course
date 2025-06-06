namespace Interfaces
{
    internal class Point : IComparable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x, int y)
        {
            X = x; Y = y;
        }

        // если virtual, то не sealed
        public int CompareTo(Point other) // virtual sealed
        {
            return Math.Sign(Math.Sqrt(X * X + Y * Y) - Math.Sqrt(other.X * other.X + other.Y * other.Y));
        }
        public override string ToString()
        {
            return $"[{X}; {Y}]";
        }
    }

    internal class SuperPoint : Point, IComparable<Point>
    {
        public SuperPoint(int x, int y) : base(x, y) { }
        public new int CompareTo(Point other)
        {
            return base.CompareTo(other);
        }
    }
}
