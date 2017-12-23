using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _01MostFrequentNumber
{
    class Program
    {
        static void Main()
        {
            var input = File.ReadAllText("input.txt").Split().Select(int.Parse).ToArray();
            //var input = "4 1 1 4 2 3 4 4 1 2 4 9 3".Split().Select(int.Parse).ToArray();
            var result = new Dictionary<int, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (!result.ContainsKey(input[i]))
                {
                    result[input[i]] = 1;
                }
                else
                {
                    result[input[i]]++;
                }
            }
            
            // За да ИЗВАДИШ КЛЮЧА САМО НА НАЙ-ГОЛ СТ-СТ!!!!:
            var myKey = result.FirstOrDefault(x => x.Value == 5).Key;
            var times=result.Values.Max();
           // Console.WriteLine($"The number {myKey} is the most frequent (occurs {times} times)");
            File.WriteAllText("Output.txt", $"The number {myKey} is the most frequent (occurs {times} times)");
        }
    }
}
