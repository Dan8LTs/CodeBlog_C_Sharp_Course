/*
Data storage location    
    Value types: On the stack or at the place of declaration.
    Reference types: In the heap
What the variable stores
    Value types: The actual value.
    Reference types: The address of the object in memory.
Behavior on assignment
    Value types: An independent copy is created.
    Reference types: The reference is copied.
Ability to have a null value
    Value types: Cannot be null (except Nullable<T>).
    Reference types: Can be null.
Support for inheritance
    Value types: Do not support inheritance (except interface implementation).
    Reference types: Support inheritance.
Examples
    Value types: int, double, bool, struct, enum.
    Reference types: class, string, array, delegate, object
*/

namespace Reference_Value_Types
{
    internal class Program()
    {
        public static void Main(string[] args)
        {
            Str str1 = new Str() { x = 5 };
            Str str2 = str1;
            str2.x = 8;
            Console.WriteLine(str1.x);

            Cl cl1 = new Cl() { x = 5 };
            Cl cl2 = cl1;
            cl2.x = 8;
            Console.WriteLine(cl1.x);

            S s = new S(1, 2, 3);
            Console.WriteLine(s.ToString());

            Console.WriteLine("\nТак как значения x и y устанавливаются в одну и ту же ячейку, данные в ней перезаписываются.");
            Offset ffst = new Offset();
            ffst.x = 12;
            ffst.y = 26;
            Console.WriteLine("x = " + ffst.x);
            Console.WriteLine("y = " + ffst.y);
        }
    }

    struct Str
    {
        public int x;
    }

    class Cl
    {
        public int x;
    }

    // It is advisable to use readonly fields to avoid duplicating data in the stack
    struct S
    {
        readonly int X;
        readonly int Y;
        readonly int Z;
        public S(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public override string ToString()
        {
            return X + " " + Y + " " + Z;
        }
    }
}