using System;

class Program
{
    static void Main()
    {
        var name = Console.ReadLine();
        var volume = int.Parse(Console.ReadLine());
        var energy = int.Parse(Console.ReadLine());
        var sugar = int.Parse(Console.ReadLine());
        // (volume/100) * energy
        Console.WriteLine($"{volume}ml {name}:");
        Console.WriteLine($"{(volume / 100.00) * energy}kcal, {(volume / 100.0) * sugar}g sugars");
    }
}

