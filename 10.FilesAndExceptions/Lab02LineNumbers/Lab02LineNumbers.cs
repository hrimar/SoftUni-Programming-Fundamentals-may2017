using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02LineNumbers
{
    class Lab02LineNumbers
    {
        static void Main(string[] args)
        {
            // Да се номерира всеки ред в текстовия файл Input.txt: !!!
            var textLines = File.ReadAllLines("Input.txt");
            var addNumLines = textLines.Select((l, index) => l = (index+1) + ". "+l);
            Console.WriteLine(string.Join("\r\n", addNumLines));
            //File.AppendAllLines("Output.txt", addNumLines);
            File.WriteAllLines("Output.txt", addNumLines);
        }
    }
}
