using Comparison;

Point p1 = new Point(10, 10);
Point p2 = new Point(20, 20);

Console.WriteLine(p1); // boxing
Console.WriteLine(p1.ToString());
Console.WriteLine(p1.GetType()); // boxing (Point) 
Console.WriteLine(p1.CompareTo(p2));

IComparable c = p1; // boxing
Console.WriteLine(c.GetType());
Console.WriteLine(c.CompareTo(p2)); // p2 boxing (-1)

p2 = (Point)c; // unboxing
Console.WriteLine(p2.ToString());


Console.ReadKey();
Console.WriteLine();


Point p = new Point(0, 0);
Console.WriteLine(p); // boxing (0, 0)
p.Change(2, 2);
Console.WriteLine(p); // boxing (2, 2)

object o = p; // boxing
Console.WriteLine(o);

((Point)o).Change(3, 3); // unboxing
Console.WriteLine(o); // (2, 2)

((IChangePoint)p).Change(4, 4);
Console.WriteLine(p); // (2, 2)

((IChangePoint)o).Change(4, 4);
Console.WriteLine(o);


Console.ReadKey();
Console.WriteLine();

/*
 Object.ReferenceEquals = Identity
 Object.Equals

 reflexivity x.Equals(x)
 symmetry x.Equals(y) => y.Equals(x)
 transitivity x.Equals(y), y.Equals(z) => x.Equals(z)
 constancy
*/

/*
 GetHashCode for ValueType:
 speed (XOR) x^y^z
 use fields
 field immutability
 constancy
*/

dynamic arg1 = 6;
dynamic arg2 = "B";
dynamic res1 = Add(arg1);
dynamic res2 = Add(arg2);

Methods.Print(res1);
Methods.Print(res2);

dynamic Add(dynamic arg)
{
    return arg + arg;
}