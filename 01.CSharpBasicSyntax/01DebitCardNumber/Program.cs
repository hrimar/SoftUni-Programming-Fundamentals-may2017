using System;


class Program
{
static void Main()
{
    var id1 = int.Parse(Console.ReadLine());
    var id2 = int.Parse(Console.ReadLine());
    var id3 = int.Parse(Console.ReadLine());
    var id4 = int.Parse(Console.ReadLine());

    Console.WriteLine($"{id1:D4} {id2:D4} {id3:D4} {id4:0000}");
}
}

