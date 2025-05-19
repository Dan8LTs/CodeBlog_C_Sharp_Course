// var использует тип данных после =
// должен быть сразу инициализирован при объявлении
var name = "Dan8LTs";
ShowVariableType(name);

// Exception x = null;
var x = (Exception)null;
ShowVariableType(x);

var numbers = new int[] { 3, 2, 23, 5 };
ShowVariableType(numbers);

var collection = new Dictionary<string, double>() { { "age", 18 } };
ShowVariableType(collection);

foreach (var item in collection)
{
    ShowVariableType(item);
}

var i = M();
static int M()
{
    return 0;
}

static void ShowVariableType<T>(T variable)
{
    Console.WriteLine(typeof(T));
}
