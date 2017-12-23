using System;

namespace Lab04Elevator
{
    class Program
    {
        static void Main()
        {
            int persons = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            double courses = (double)persons / capacity;

            Console.WriteLine(Math.Ceiling(courses));
        }
    }
}
