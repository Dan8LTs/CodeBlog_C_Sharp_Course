using System.Text;

namespace Operator_Overloading
{
    internal struct Complex_Number
    {
        // Real part
        public double Re { get; }
        // Imaginary part
        public int Im { get; }

        public Complex_Number(double re, int im)
        {
            Re = re;
            Im = im;
        }


        #region INT
        public int ToInt()
        {
            return (int)Re;
        }

        public static implicit operator Complex_Number(int i)
        {
            return new Complex_Number(i);
        }
        public static explicit operator int(Complex_Number i)
        {
            return i.ToInt();
        }
        public Complex_Number(int re)
        {
            Re = re;
            Im = 0;
        }
        #endregion

        #region Double
        public double ToDouble()
        {
            return Re;
        }
        public static implicit operator Complex_Number(double i)
        {
            return new Complex_Number(i);
        }
        public static explicit operator double(Complex_Number i)
        {
            return i.ToDouble();
        }
        public Complex_Number(double re)
        {
            Re = re;
            Im = 0;
        }
        #endregion


        public static Complex_Number operator +(Complex_Number c1, Complex_Number c2)
        {
            return new Complex_Number(c1.Re + c2.Re, c1.Im + c2.Im);
        }
        public static Complex_Number Add(Complex_Number c1, Complex_Number c2)
        {
            return c1 + c2;
        }
        public override string ToString()
        {
            if (Im < 0)
            {
                return new StringBuilder().AppendFormat("({0} - {1}i)", Re, -1 * Im).ToString();
            }
            else if (Im > 0)
            {
                return new StringBuilder().AppendFormat("({0} + {1}i)", Re, Im).ToString();
            }
            else
            {
                return Re.ToString();
            }
        }
    }
}