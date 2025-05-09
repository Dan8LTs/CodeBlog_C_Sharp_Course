using Reference_Value_Types;

/*
Место хранения данных
    Значимые типы: В стеке или в месте объявления.
    Ссылочные типы: В куче
Что хранит переменная
    Значимые типы: Само значение.
    Ссылочные типы: Адрес объекта в памяти.
Поведение при присваивании
    Значимые типы: Создается независимая копия.
    Ссылочные типы: Копируется ссылка.
Возможность иметь значение null
    Значимые типы: Не могут быть null (кроме Nullable<T>).
    Ссылочные типы: Могут быть null.
Поддержка наследования
    Значимые типы: Не поддерживают наследование (кроме реализации интерфейсов).
    Ссылочные типы: Поддерживают наследование.
Примеры
    Значимые типы: int, double, bool, struct, enum.
    Ссылочные типы: class, string, array, delegate, object
*/

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
Console.WriteLine("x = "+ffst.x);
Console.WriteLine("y = "+ffst.y);

struct Str
{
    public int x;
}

class Cl
{
    public int x;
}

// желательно использовать readonly поля, чтобы избежать дублирования данных в стеке
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