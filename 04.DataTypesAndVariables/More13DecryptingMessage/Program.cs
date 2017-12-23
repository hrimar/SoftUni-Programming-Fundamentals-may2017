using System;

namespace More13DecryptingMessage
{
    class Program
    {
        static void Main()
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            string result = string.Empty;

            for (int i = 0; i < n; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                result += (char)(key + symbol);
            }
            Console.WriteLine(result);
        }
    }
}
