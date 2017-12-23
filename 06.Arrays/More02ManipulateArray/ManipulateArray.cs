using System;
using System.Collections.Generic;
using System.Linq;

namespace More02ManipulateArray
{
    class ManipulateArray
    {
        static void Main()
        {        
            var words = Console.ReadLine().Split(' ').ToArray();
            int n = int.Parse(Console.ReadLine());
        
           for (int i = 0; i < n; i++)
            {
                var commandsArray = Console.ReadLine().Split(' ').ToArray();
                string command = commandsArray[0];
                int commandIndex = -1; 
                string replaceWord = string.Empty;

                if (commandsArray.Length>1)
                {
                    commandIndex = int.Parse(commandsArray[1]);
                    replaceWord = commandsArray[2];
                }                

                switch (command)
                {
                    case "Reverse":
                        words=words.Reverse().ToArray(); break; // не само words.Reverse();!!! 
                    case "Distinct":
                        words = words.Distinct().ToArray(); break; // words=words.Distinct().ToArray()!!!
                    case "Replace":
                        words[commandIndex] = replaceWord;
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", words));
        }
    }
}
