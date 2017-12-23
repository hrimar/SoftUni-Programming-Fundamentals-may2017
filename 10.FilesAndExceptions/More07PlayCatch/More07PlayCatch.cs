using System;
using System.Collections.Generic;
using System.Linq;

namespace More07PlayCatch
{
    class More07PlayCatch
    {
        static void Main()
        {
            // Имате масив и команди. Ако се подаде грешен индекс или число да отпечата съотв грешка:
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            var exceptionsCount = 0;
            while (exceptionsCount< 3)
            {
                var commandLine = Console.ReadLine().Split().ToList();
                var command = commandLine[0];
                var index = 0;
               
                var endIndex = 0;
                try
                {
                    index = int.Parse(commandLine[1]); //      

                    switch (command)
                    {
                        case "Replace":
                            var element = int.Parse(commandLine[2]);
                            input[index] = element; // if(index>=input.Length

                            break;
                        case "Show":
                            Console.WriteLine($"{input[index]}");// if
                            break;
                        case "Print":
                             index= int.Parse(commandLine[1]);
                             endIndex= int.Parse(commandLine[2]);
                        
                            Console.WriteLine
                           (string.Join(", ", input.GetRange(index, endIndex - index + 1))); // !!!
                            break;
                    }
                }
                catch
                {
                    if ((index >= input.Count || index<0) || (endIndex>= input.Count)) 
                    {
                        // (System.IndexOutOfRangeException)
                        Console.WriteLine("The index does not exist!");
                    }
                    else // (System.FormatException)
                    {
                        Console.WriteLine("The variable is not in the correct format!");
                    }
                    exceptionsCount++;
                }
                if (exceptionsCount == 3)
                    Console.WriteLine(string.Join(" ", input));
            }


            // Решение 2: 
            //var nums = Console.ReadLine().Split()
            //     .Select(int.Parse).ToList();

            //var exepCount = 0;

            //while (exepCount < 3)
            //{
            //    var input = Console.ReadLine().Split();
            //    var command = input[0];
            //    try
            //    {
            //        if (command == "Replace")
            //        {
            //            var index = int.Parse(input[1]);
            //            nums[index] = int.Parse(input[2]);
            //        }
            //        else if (command == "Print")
            //        {
            //            var index = int.Parse(input[1]);
            //            var endIndex = int.Parse(input[2]);
            //            Console.WriteLine
            //               (string.Join(", ", nums.GetRange(index, endIndex - index + 1)));
            //        }
            //        else if (command == "Show")
            //        {
            //            var index = int.Parse(input[1]);
            //            Console.WriteLine(nums[index]);
            //        }
            //    }
            //    catch
            //    {
            //        if (input.Length > 2)
            //        {
            //            var check = 0;
            //            if (int.TryParse(input[1], out check) &&
            //                int.TryParse(input[2], out check))
            //            {
            //                Console.WriteLine("The index does not exist!");
            //            }
            //            else
            //                Console.WriteLine("The variable is not in the correct format!");
            //        }
            //        else
            //        {
            //            var check = 0;
            //            if (int.TryParse(input[1], out check))
            //            {
            //                Console.WriteLine("The index does not exist!");
            //            }
            //            else
            //                Console.WriteLine("The variable is not in the correct format!");
            //        }
            //        exepCount++;
            //    }
            //}
            //Console.WriteLine(string.Join(", ", nums));
        }
    }
}
