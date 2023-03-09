using System;
using System.Globalization;
using System.Resources;

public class Localisation
{
    public static void Main()
    {
        // Select the current culture randomly.
        string[] cultures = { "de-DE", "en-US", "fr-FR" };
        Random rnd = new Random();
        int index = rnd.Next(0, cultures.Length);

        var culture = CultureInfo.CreateSpecificCulture(cultures[index]);
        Console.WriteLine($"System language is {CultureInfo.CurrentUICulture.Name}");
        Console.WriteLine($"The current culture is {culture.Name}");

        ResourceManager rm = new ResourceManager("Localisation.Resources.Messages", typeof(Localisation).Assembly);
        string greeting = rm.GetString("Greeting", culture);

        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("{0} {1}!", greeting, name);

        Console.ReadKey();
    }
}