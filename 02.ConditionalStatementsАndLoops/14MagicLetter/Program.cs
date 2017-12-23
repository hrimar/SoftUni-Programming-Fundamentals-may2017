using System;

namespace _14MagicLetter
{
    class Program
    {
        static void Main()
        {
            char w1 = char.Parse(Console.ReadLine());
            char w2 = char.Parse(Console.ReadLine());
            char wThird = char.Parse(Console.ReadLine());
            for (char i = w1; i <= w2; i++)
            {
                for (char j = w1; j <= w2; j++)
                {
                    for (char k = w1; k <= w2; k++)
                    {
                        if (i == wThird || j == wThird || k == wThird)
                        {
                            continue;
                        }
                        else
                        Console.Write($"{i}{j}{k} ");
                    }

                }
            }
            Console.WriteLine();
        }
    }
}
