using System;
using System.Collections.Generic;
using System.Linq;

namespace More07TakeSkipRope
{
    class More07TakeSkipRope
    {
        static void Main()
        {
            // otvratitelno uslovie 100/100:
            var input = Console.ReadLine();
            var inputChars=input.ToCharArray();
            var numbersStr = input.Where(n => char.IsNumber(n)).ToArray(); //.IsDigit() ???
            var letters = input.Where(n => !(char.IsNumber(n))).ToArray();

            //for (int i = 0; i < input.Length; i++)
            //{
            //    if (char.IsNumber(input[i]))
            //    {
            //        numbersStr += input[i] + " ";
            //    }
            //    else
            //    {
            //        letters += input[i] + " ";
            //    }
            //}
            //string numbersStr = "0 4 4 1 7 0 ";
            //var numbers = numbersStr.Trim().Split().Select(int.Parse).ToArray();
            //var takeList = numbers.Where((n, index) => (n, index % 2 == 0)).ToArray();

            var numbers = numbersStr.Select(n=>int.Parse(n.ToString())).ToArray();
            // Така с LINQ не става да се вземат елементи по индекс:
            //var takeList = numbers..Where((n, index) => (n, index % 2 == 0)).ToArray();
            //var skipList = numbers.Where(n => n % 2 == 1).ToArray();

            var takeList = new List<int>();
            var skipList = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 0)
                    takeList.Add(numbers[i]);
                else
                    skipList.Add(numbers[i]);
            }
            var result = string.Empty;
            var totalSkip = 0;
                for (int i = 0; i < takeList.Count; i++)
                {
                
                //result += letters.Substring(skipList[i], takeList[i]);
                // result += letters.Take(takeList[i]).Skip(skipList[i]).ToString(); // ???
                result += new string(letters.Skip(totalSkip).Take(takeList[i]).ToArray()); // puuu !!!!!!
                totalSkip += takeList[i] + skipList[i];
            }
                Console.WriteLine(result);
           
            //Console.WriteLine(string.Join(" ", takeList));
            //Console.WriteLine(string.Join(" ", skipList));
        }
    }
}
