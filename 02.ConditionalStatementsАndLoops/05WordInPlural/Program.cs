using System;

namespace _05WordInPlural
{
    class Program
    {
        static void Main()
        {
            // пример за извличане на последните символи от string с string.EndsWith("sh"):
            var word = Console.ReadLine();
            var result = string.Empty;

            if (word[word.Length - 1] == 'y')
            {
                result = word.Remove(word.Length - 1);
                //Console.WriteLine(word[word.Length - 1]);
                Console.WriteLine(result+"ies");
           }
            //else if(word[word.Length - 1] == 'z' || word[word.Length - 1] == 's' || word[word.Length - 1] == 'h' || word[word.Length - 1] == 'o')
            else if(word.EndsWith("sh") || word.EndsWith("ch") || word[word.Length - 1] == 'o' ||
                    word[word.Length - 1] == 'z' || word[word.Length - 1] == 's' || word[word.Length - 1] == 'x')
            {
                result = word + "es";
                Console.WriteLine(result);
            }
            else
            {
                result = word + 's';
                Console.WriteLine(result);
            }

        }
    }
}
