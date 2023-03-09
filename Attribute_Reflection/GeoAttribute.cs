using System;

namespace Attrubute__Reflection
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Constructor)]
    class GeoAttribute : System.Attribute
    {
        public int X { get; set; }
        public int Y { get; set; }

        public GeoAttribute() { }

        public GeoAttribute(int x, int y)
        {//Здесь должна быть проверка входных данных
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"{X}; {Y}";
        }
    }
}
