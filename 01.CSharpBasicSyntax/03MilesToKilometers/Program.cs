using System;

class Program
{
    static void Main(string[] args)
    {
        var miles = decimal.Parse(Console.ReadLine());
        //var km = miles * 1.60934;
        Console.WriteLine($"{(miles*1.60934m):0.00}");
    }
}
