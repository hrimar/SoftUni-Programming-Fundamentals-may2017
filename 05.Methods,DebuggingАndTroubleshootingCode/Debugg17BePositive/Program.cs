using System;
using System.Collections.Generic;
using System.Linq;

namespace Debugg17BePositive
{
    class Program
    {
        public static void Main()
        {
            int countSequences = int.Parse(Console.ReadLine());

            for (int i = 0; i < countSequences; i++)
            {
                string[] input = Console.ReadLine().Trim().Split(' ');
                var numbers = new List<int>();
                var foundedNums = new List<int>();

                for (int j = 0; j < input.Length; j++)
                {
                    if (!input[j].Equals(string.Empty))
                    {
                        int num = int.Parse(input[j]);//i
                        numbers.Add(num);
                    }
                }

                bool found = false;

                for (int j = 0; j < numbers.Count; j++)
                {
                    //found = false;
                    int currentNum = numbers[j];

                    if (currentNum >= 0)
                    {
                        foundedNums.Add(currentNum);

                        found = true;
                    }

                    else
                    {
                        if (currentNum +1 >= numbers.Count)
                        {
                            continue;
                        }
                            currentNum = numbers[j]+numbers[j + 1];
                     
                        if (currentNum >= 0)
                        {                            
                            foundedNums.Add(currentNum);

                            found = true;
                        }
                        j++;
                    }

                }

                if (!found)
                {
                    Console.WriteLine("(empty)");
                }
                Console.WriteLine(string.Join(" ", foundedNums));
            }
        }
    }
}
