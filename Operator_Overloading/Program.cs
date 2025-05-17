using Operator_Overloading;

var c1 = new Complex_Number(4, 8);
var c2 = new Complex_Number(10, -20);
var c3 = c1 + c2;
Console.WriteLine(c3);

var c4 = new Complex_Number(66);
int c5 = c4.ToInt();

Complex_Number c6 = 88;
int j = (int)c6;

Complex_Number c7 = 8.8;
var d = (double)c7;