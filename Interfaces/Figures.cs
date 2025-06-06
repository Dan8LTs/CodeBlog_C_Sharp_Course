namespace Interfaces
{
    internal interface IFigure
    {
        double GetArea();
    }

    internal class Circle : IFigure
    {
        public double Radius { get; }
        public Circle(double radius)
        {
            if (radius < 0) throw new ArgumentException("Радиус должен быть > 0", nameof(radius));
            Radius = radius;
        }
        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
    internal class Square : IFigure
    {
        public double Length { get; }
        public Square(double length)
        {
            if (length < 0) throw new ArgumentException("Длина стороны должна быть > 0", nameof(length));
            Length = length;
        }
        public double GetArea()
        {
            return Length * Length;
        }
    }
}
