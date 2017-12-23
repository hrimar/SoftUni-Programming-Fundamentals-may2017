using System;

class Program
{
    static void Main()
    {
    var name = Console.ReadLine();
    var age = int.Parse(Console.ReadLine());
    var id = int.Parse(Console.ReadLine());
    var salary = double.Parse(Console.ReadLine());

    Console.WriteLine($"Name: {name}");
    Console.WriteLine($"Age: {age}");
    Console.WriteLine($"Employee ID: {id:D}");
    Console.WriteLine($"Salary: {salary:f2}");
    }
}

