using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace more06DNASequences
{
    class Program
    {
        static void Main()
        {
            // maleee ?!

            var n = int.Parse(Console.ReadLine());

            char presufix = ' ';
            char first = ' ';
            char second = ' ';
            char third = ' ';

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    for (int k = 1; k <= 4; k++)
                    {
                        presufix = n > i + j + k ? 'X' : 'O';
                        // Console.WriteLine($"{presufix}{i}{j}{k}{presufix}");
                        switch (i)
                        {
                            case 1: first = 'A'; break;
                            case 2: first = 'C'; break;
                            case 3: first = 'G'; break;
                            case 4: first = 'T'; break;
                        }
                        switch (j)
                        {
                            case 1: second = 'A'; break;
                            case 2: second = 'C'; break;
                            case 3: second = 'G'; break;
                            case 4: second = 'T'; break;
                        }
                        switch (k)
                        {
                            case 1: third = 'A'; break;
                            case 2: third = 'C'; break;
                            case 3: third = 'G'; break;
                            case 4: third = 'T'; break;
                        }
                        Console.Write($"{presufix}{first}{second}{third}{presufix} ");

                        if (k==4)          // за да ги пише: xxxxx xxxxx xxxxx xxxxx
                        {                               //   xxxxx xxxxx xxxxx xxxxx
                            Console.WriteLine();
                        }
                      
                    }
                }
            }
        }
    }
}
