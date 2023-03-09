namespace Object
{
    public class Point
    {
        public int X { get; set; }
        public Point Y { get; set; }
        public override bool Equals(object obj)
        {
            //НИКОГДА не должен кидать exception
            //is - bool if this types =
            //as - преобразует в этот тип or null


            if (obj is Point point)
            {
                return X == point.X;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return X;
        }

        public override string ToString()
        {
            return X.ToString();
        }

        // Clone - Если внутри класса содержатся значимые типы, они будут продублированы, но если ссылочные типы, то ссылка будет одинаковой.
        // DeepClone or = - Если внутри класса содержатся значимые или ссылочные типы они будут продублированы.
        public Point Clone()
        {
            //Clone
            return MemberwiseClone() as Point;
            //DeepClone
            //var res = (Point)MemberwiseClone();
            //res.Y = Y.Clone();
            //return res;
        }

    }
}
