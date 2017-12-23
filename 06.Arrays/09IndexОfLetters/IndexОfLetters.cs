using System;
using System.Collections.Generic;
using System.Linq;

namespace _09IndexОfLetters
{
    class IndexОfLetters
    {
        static void Main()
        {
            //значи от масив и стринг се търсят еднакви елемени и на кой позиции са в масива:
            char[] alfabet = new char[26];
            string chars = Console.ReadLine().ToLower();
            
            // прази масив с азбуката:
            for (int i = 0; i < alfabet.Length; i++) 
            {
                alfabet[i] = (char)(i + 97);       //Console.WriteLine($"{alfabet[i]} -> {i}");
            }
            PrintEqualschars(alfabet, chars);
        }

        private static void PrintEqualschars(char[] alfabet, string chars)
        {
            for (int j = 0; j < chars.Length; j++)
            {
                for (int i = 0; i < alfabet.Length; i++)
                {
                    //if (chars.Contains(alfabet[i])) - taka ne stana
                    if (chars[j] == alfabet[i])
                    {
                        Console.WriteLine($"{chars[j]} -> {i} ");
                    }
                }
            }
        }
    }
}
