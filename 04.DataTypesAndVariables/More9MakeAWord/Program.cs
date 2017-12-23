using System;

namespace More9MakeAWord
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string result = string.Empty;
            for (int i = 0; i < n; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                result += letter;              
            }
            Console.Write($"The word is: {result}");
            Console.WriteLine();
        }
    }
}
