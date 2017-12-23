﻿using System;

namespace _15Substring
{
    class Substring
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            int jump = int.Parse(Console.ReadLine());
            jump += 1;

           // const char Search = 'p';
            bool hasMatch = false;
                        
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'p')
                {
                    hasMatch = true;

                    int endIndex = jump;                   

                    if (endIndex > (text.Length-i))
                    {
                        endIndex = (text.Length - i);
                    }

                    string matchedString = text.Substring(i, endIndex);
                    Console.WriteLine(matchedString);
                    i += jump-1;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
