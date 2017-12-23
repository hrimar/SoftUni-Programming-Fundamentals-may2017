using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace More05WritetoFile
{
    class More05WritetoFile
    {
        static void Main()
        {
            // Да се махнат всички ".,!?:" символи от текста:
            var result = new List<string>();
            var separators = ".,!?:".ToCharArray();
            var input = File.ReadAllText("sample_text.txt");
        var redact =input.Split(separators, StringSplitOptions
            .RemoveEmptyEntries).ToArray();
            
            var finalString = string.Join("", redact);
            File.WriteAllText("output.txt", finalString);


        }
    }
}
