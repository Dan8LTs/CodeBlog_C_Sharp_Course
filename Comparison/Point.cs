namespace Comparison
{
    internal struct Point : IComparable, IChangePoint
    {
        private int X;
        private int Y;
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int CompareTo(object? obj)
        {
            if (obj is Point point)
            {
                return CompareTo(point);
            }
            else
            {
                throw new ArgumentException("the object being compared is not a point");
            }
        }
        public int CompareTo(Point p)
        {
            return Math.Sign(Math.Sqrt(X * X + Y * Y) - Math.Sqrt(p.X * p.X + p.Y * p.Y));
        }
        public void Change(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return string.Format("({0}, {1})", X, Y);
        }
    }
}
