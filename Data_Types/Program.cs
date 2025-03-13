using System;

namespace Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var i = 5;
            double g = 5.8;
            char h = 'v';
            bool b = true;
            string x = "Hi, its a string";
            decimal d = 0.1M;
            float c = 21.5f;


            System.Int32 m = new System.Int32();
            float n = Convert.ToSingle(c);
            Console.WriteLine(n);

            // sbyte -128 ... 128 (8 bit) (not in CLS) System.SByte
            // byte 0 ... 255 (8 bit) System.Byte
            // short (16 bit) System.Int16
            // usort (16 bit) (not in CLS) System.Uint16
            // int (32 bit) System.Int32
            // uint (32 bit) (not in CLS) System.Uint32
            // long (64 bit) System.Int64
            // ulong (64 bit) (not in CLS) System.Uint64
            // char (16 bit) System.Char
            // float (32 bit) System.Single
            // double (64 bit) System.Double
            // bool (8 bit) System.Boolean
            // decimal (128 bit) System.Decimal
            // string (char array) System.String
            // object (base type) System.Object
            // dynamic System.Object

            int t = 8;
            long l = t; // implicit cast
            t = (int)l; // explicit cast
            Console.WriteLine(8.GetType());

            double dbl = t;
            int k = (int)dbl;

            int nt = 200 + 800; // calculated at compile time
            string s = "a" + "b";
            int bl = 0001_0010_1101;
            Console.WriteLine(bl);



            byte bt = 100;
            bt += 200; // type overflow
            Console.WriteLine(bt);

            // bt = checked((byte)(bt + 800));  calls overflow exception
            // /checked+
            checked
            {
                bt = unchecked((byte)(bt + 800));
                Console.WriteLine(bt);

                int nbr = 1000;
                // checked doesn't influence on methods
                Console.WriteLine(Method(nbr));
            }
        }

        private static byte Method(int nbr)
        {
            byte bt = (byte)nbr;
            return bt;
        }
    }
}
