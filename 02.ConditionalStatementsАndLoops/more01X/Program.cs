using System;

namespace more01X
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n/2; i++)
            {
                Console.Write(new string(' ', i));
                Console.Write('x');
                Console.Write(new string(' ', n-2-2*i));
                Console.Write('x');
                Console.WriteLine(new string(' ', i));
            }
            Console.Write(new string(' ', n/2));
            Console.WriteLine('x');
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string(' ', n/2- 1-i));
                Console.Write('x');
                Console.Write(new string(' ', 1+ 2*i)); // middle part
                Console.Write('x');
                Console.WriteLine(new string(' ', n /2-i-1));
            }
        }
    }
}
