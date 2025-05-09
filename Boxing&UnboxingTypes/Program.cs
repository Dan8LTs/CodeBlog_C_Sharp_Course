int a = 18;
C c = new C();
c.v = a; // boxing
int d = c.v; // unboxing

int i = 6;
// Boxing: an object from the stack is moved to the heap
object o = i;
// Unboxing: an object from the heap is moved to the stack
int j = (int)o;
Console.WriteLine(j);
// Console.WriteLine((double)o); => Invalid cast exception

//boxing
Console.WriteLine(i + "!");

Point p = new Point(1, 2);
object obj = p;
p = new Point(3, 4);
Console.WriteLine(obj);

Console.WriteLine();

int n = 8;
// The value is duplicated in the stack, unboxing occurs
Console.WriteLine($"{n}, {n}, {n}");
object n2 = n;
// Object is a reference type, the value is not copied.
Console.WriteLine($"{n2}, {n2}, {n2}");

class C
{
    public int v;
}
struct Point
{
    private int X;
    private int Y;
    public Point(int x, int y) { X = x; Y = y; }
    public override string ToString()
    {
        return X + " " + Y;
    }
}