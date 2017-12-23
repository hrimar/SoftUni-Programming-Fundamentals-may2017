using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab05ShortWordsSorted
{
    class Lab05ShortWordsSorted
    {
        static void Main()
        {
            char[] separators = ". , : ; ( )[ ] \" ' \\ / ! ?  ".ToCharArray();
            var words = Console.ReadLine().ToLower()
                .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                .Distinct().Where(w => w.Length<5).OrderBy(w=>w).ToArray();

            Console.WriteLine(string.Join(", ", words));
        }
    }
}
