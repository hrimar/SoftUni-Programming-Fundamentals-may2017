using System;

namespace Lab06TriplesOfLetters
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (char i = 'a'; i < 'a' + n; i++)
            {
                for (char j = 'a'; j < 'a' + n; j++)
                {
                    for (char k = 'a'; k < 'a' + n; k++)
                    {
                        Console.Write($"{i}{j}{k} ");
                        Console.Write("\r"); // защо не става да печата с превъртане на символите?

                    }
                }
            }


            //for (int i = 0; i < 1000000; i++)
            //{
            //    Console.Write(i);
            //    Console.Write('\r');

            //}

        }
    }
}
