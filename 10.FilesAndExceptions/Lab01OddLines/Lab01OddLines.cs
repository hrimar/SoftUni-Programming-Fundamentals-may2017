using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Lab01OddLines
{
    class Lab01OddLines
    {
        static void Main()
        {
            // да се прочетат всички нечетни редове от файла input.txt:
            var allLines = File.ReadAllLines("Input.txt");
            var oddLines = allLines.Where((l, index) => index % 2 == 1);
            Console.WriteLine(string.Join("\r\n", oddLines));
            //File.AppendAllLines("Output.txt", oddLines);
            File.WriteAllLines("Output.txt", oddLines);
        }
    }
}
