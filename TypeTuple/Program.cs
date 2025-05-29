using System.Dynamic;

var fibbonachi = Tuple.Create(1, 1, 2, 3, 5, 8, 13);
var geometricProgression = new Tuple<int, int, int, int, int>(1, 2, 4, 8, 16);
var temp = new Tuple<double, StreamWriter, DateTime>(8.4, new StreamWriter("test.txt"), DateTime.Now);
Console.WriteLine(temp.Item1);

dynamic e = new ExpandoObject();
e.x = 9;
e.y = "Something";
e.z = null;
// new KeyValuePair<string, object>("PropertyName", "Value");
e.PropertyName = "Value";

var e2 = (IDictionary<string, object>)e;
e2.Remove("x");
foreach (var item in e2)
{
    Console.WriteLine($"Key = {item.Key}, Value = {item.Value}");
}

// ValueTuple
var nickname = ("Dan", 8, "LTs");
Console.WriteLine(nickname.Item1 + nickname.Item2 + nickname.Item3);

ValueTuple<string, string, string> person1 = ("Alexeev", "Vladimir", "Dmitrievich");
(string Surname, string Name, string Patronymic) person2 = ("Ivanov", "Ivan", "Ivanovich");
Console.WriteLine(person2.Name);
var person3 = (Surname: "Vadimov", Name: "Vadim");

var single = ValueTuple.Create(8);
// var arithmeticProgression = new Tuple<int, int, int, int, int, int, int, Tuple<int, int, int>>(1, 2, 3, 4, 5, 6, 7, new Tuple<int, int, int>(8, 9, 10));
var arithmeticProgression = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
Console.WriteLine(arithmeticProgression.Item1);

var Name = "Minecraft";
var Genre = "Sandbox";
// var game = (Name: Name, Genre: Genre);
var game = (Name, Genre);
Console.WriteLine(game);

var minmax = MinMax(6, 2);
Console.WriteLine(minmax);
var minmax2 = MinMax2((8, 4));
Console.WriteLine(minmax2);
static Tuple<int, int> MinMax(int v1, int v2)
{
    return new Tuple<int, int>(Math.Min(v1, v2), Math.Max(v1, v2));
}
static (int Min, int Max) MinMax2((int v1, int v2) pair)
{
    return (Math.Min(pair.v1, pair.v2), Math.Max(pair.v1, pair.v2));
}

// Deconstructor
(string name, string surname, string _) = WhoAmI(person1);
Console.WriteLine(name, surname);
(string, string, string) WhoAmI((string Surname, string Name, string Patronymic) person)
{
    return (person.Name, person.Surname, person.Patronymic);
}