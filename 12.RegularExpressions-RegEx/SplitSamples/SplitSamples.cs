using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class SplitSamples
{
    static void Main()
    {
        //string[] words = Regex.Split("Аз съм, супер      по - готин от 56, 78",
        //    @"[,.!\- ]+");

        //Console.WriteLine(string.Join(", ", words)); // -> Аз, съм, супер, по, готин, от, 56, 78

        //--------------------
        //var matches=Regex.Matches("Аз съм, супер   по-готин от 56.78", @"[А-Яа-я-]+");
        //foreach (var match in matches)
        //{
        //    Console.WriteLine(match);    // -> пак дава същите думи, но хваща и по-готин!
        //}
        //----------------

        //Да се заменит всички думи с главни букви с толкова звездички, колкото символи са:
        //string text = "Zdrasti, AAA, zdrasti, BB, zdrAASti";
        //string result = Regex.Replace(text, @"\b[A-Z]+\b", w => new string('*', w.Length));
        //Console.WriteLine(result);  // --> Zdrasti, ***, zdrasti, **, zdrAASti

        //Пример за Multiline:
        foreach (Match m in Regex.Matches(
            @"някакъв текст
            10001      
        още текст
                    202
        и число", @"^\s*(\d+)\s*$", RegexOptions.Multiline))
        {
            Console.WriteLine(m.Groups[1]);  // -> 10001  \n  202
        }


    }
}

