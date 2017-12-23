using System;

namespace _01HelloName
{
    class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();
            PrintName(name);
        }

        static void PrintName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
   
    }
}
