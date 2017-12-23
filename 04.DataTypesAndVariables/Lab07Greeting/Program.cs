using System;

namespace Lab07Greeting
{
    class Program
    {
        static void Main()
        {
            var firstName = Console.ReadLine();
            var lastName = Console.ReadLine();
            var years = int.Parse(Console.ReadLine());
            Console.WriteLine($"Hello, {firstName} {lastName}. You are {years} years old.");

        }
    }
}
