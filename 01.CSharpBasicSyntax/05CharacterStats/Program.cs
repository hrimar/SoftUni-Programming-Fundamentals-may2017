using System;

class Program
{
    static void Main()
    {
        // хитра задачка :)
    var name = Console.ReadLine();
    var currentHealth = int.Parse(Console.ReadLine());
    var totalHealth = int.Parse(Console.ReadLine());
    var currentEnergy = int.Parse(Console.ReadLine());
    var totalEnergy = int.Parse(Console.ReadLine());

        char healt = '|';
        Console.WriteLine($"Name: {name}");
        Console.WriteLine
            ($"Health: |"+new string('|', currentHealth)+ new string('.', totalHealth-currentHealth)+'|');
        Console.WriteLine
            ($"Energy: |" + new string('|', currentEnergy) + new string('.', totalEnergy-currentEnergy)+'|');
    }
}

