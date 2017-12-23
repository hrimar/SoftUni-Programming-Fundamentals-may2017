using System;
using System.Collections.Generic;
using System.Linq;

namespace More03SafeManipulation
{
    class SafeManipulation
    {
        static void Main()
        {
 // Извод: значи мове и while (true) и веднага вътре: if(command == "END") -> break;
            var words = Console.ReadLine().Split(' ').ToArray();
                 
           
            while (true)
            {
                var commandsArray = Console.ReadLine().Split(' ').ToArray();
                string command = commandsArray[0];
                if(command == "END")
                {
                   break;
                }

                switch (command)
                {
                         case "Reverse":
                        Array.Reverse(words); break; // !!! или words=words.Reverse().ToArray();
                    case "Distinct":
                        words = words.Distinct().ToArray(); break;
                    case "Replace":
                        int commandIndex = int.Parse(commandsArray[1]);
                        string replaceWord = commandsArray[2];

                        if (commandIndex < words.Length && commandIndex >=0 )
                        {
                            words[(commandIndex)] = replaceWord;                           
                        }
                        else
                        {
                            Console.WriteLine("Invalid input!");
                        }
                        break;
                    default: Console.WriteLine("Invalid input!"); break;
                }
                
            }
            Console.WriteLine(string.Join(", ", words));

        }
    }
}
