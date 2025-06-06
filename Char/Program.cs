using System.Globalization;

System.Char абвԬ = new System.Char();
Console.WriteLine(абвԬ);

MinMaxChar();
Console.WriteLine();
CharUnicodeCategory();
Console.WriteLine();
CharToUpperCultureInfo();
Console.WriteLine();
EqualsSymbol();
Console.WriteLine();
CompareSymbols();
Console.WriteLine();
ConvertCharAndString();
Console.WriteLine();
SymbolToNumber();
Console.WriteLine();
ConvertChar();

void SymbolToNumber()
{
    var three = char.GetNumericValue('\u0033');
    Console.WriteLine(three);
    Console.WriteLine((int)'\u0033');

    var quarter = char.GetNumericValue('\u00bc');
    Console.WriteLine(quarter);
    Console.WriteLine((int)'\u00bc');

    var letter = char.GetNumericValue('a');
    Console.WriteLine(letter);
    Console.WriteLine((int)'a');
}

void ConvertChar()
{
    Console.WriteLine((char)53);
    Console.WriteLine((int)(char)53);
    Console.WriteLine((int)'A');

    var negativeNumber = -8;
    var tooBigNumber = 65602;
    var d = 6.2;

    Console.WriteLine((char)negativeNumber);
    Console.WriteLine((char)tooBigNumber);

    Console.WriteLine((char)d); // пустая строка

    Console.WriteLine(Convert.ToChar(65));
    Console.WriteLine(Convert.ToInt32('B'));

    // boxing (char - value type)
    Console.WriteLine(((IConvertible)51).ToChar(null));
    Console.WriteLine(((IConvertible)'B').ToInt32(null));
}

void ConvertCharAndString()
{
    var str = "Dan";
    var oneSymbolString = "5";

    Console.WriteLine(char.Parse(oneSymbolString));

    if (char.TryParse(str, out char symbol))
    {
        Console.WriteLine(symbol);
    }
    else
    {
        Console.WriteLine($"Impossible");
    }
}

void CompareSymbols()
{
    Console.WriteLine((int)'I');
    Console.WriteLine((int)'İ');
    Console.WriteLine('I'.CompareTo('İ'));
}

void EqualsSymbol()
{
    char s1 = 'μ';
    char s2 = 'µ';

    Console.WriteLine('μ'.Equals(s1));
    Console.WriteLine(s1.Equals(s2));

    Console.WriteLine((int)s1);
    Console.WriteLine((int)s2);
}

void CharUnicodeCategory()
{
    char symbol = 'A';
    Console.WriteLine(char.GetUnicodeCategory(symbol));

    if (char.IsPunctuation(symbol))
    {
        Console.WriteLine("This is a punctuation");
    }
    else
    {
        Console.WriteLine("This isn't a punctuation");
    }
}

void MinMaxChar()
{
    Console.WriteLine(char.MinValue);
    Console.WriteLine(char.MaxValue);

    Console.WriteLine((int)char.MinValue);
    Console.WriteLine((int)char.MaxValue);
}

void CharToUpperCultureInfo()
{
    var symbol = 'i';

    // не используют набор региональных стандартов
    Console.WriteLine(char.ToLowerInvariant(symbol));
    Console.WriteLine(char.ToUpperInvariant(symbol));

    // используют набор региональных стандартов из свойств вызывающего потока
    Console.WriteLine(char.ToLower(symbol));
    Console.WriteLine(char.ToUpper(symbol));

    var cultureInfo = CultureInfo.GetCultureInfo("tr");
    Console.WriteLine(char.ToUpper(symbol, cultureInfo)); //İ
}