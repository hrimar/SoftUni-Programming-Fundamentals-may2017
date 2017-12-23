using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _02IndexOfLetters
{
    class Program
    {
        static void Main()
        {
            var letters = new char[26];
            for (int i = 0; i < letters.Length; i++)
            {
                letters[i] = (char)(i + 97);
            }
            // Console.WriteLine(string.Join(" ", letters));
            var input = File.ReadAllText("input.txt");
            var result = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < letters.Length; j++)
                {
                    if(letters[j]==input[i])
                    {
                        result.Add($"{input[i]} -> {j}");
                        //Console.WriteLine($"{input[i]} -> {j}");
                       
                    }
                }
            }
           
            //Console.WriteLine(string.Join("\r\n", result));
              File.WriteAllLines("Output.txt", result);
        }
    }
}
