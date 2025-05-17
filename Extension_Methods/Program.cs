using Extension_Methods;
using System.Text;

var sb = new StringBuilder("My string");

// var index = StringBuilderExtensions.IndexOf(sb.Replace(" ", "!"), '!');
var index = sb.Replace(" ", "!").IndexOf('!');
Console.WriteLine(index);

var str = " My string";
Action d = str.Print;
d();