using System;
using System.Collections.Generic;
using System.Linq;

namespace _05ArrayManipulator
{
    class Program
    {
        static void Main()
        {
            // хъм нещо  maj бъркам ????
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var commands = Console.ReadLine().Split(' ').ToList();
            var result = new List<int>();

            while (commands[0] != "print")
            {
                if (commands[0] == "add")
                {
                    var currentIndex = int.Parse(commands[1]);
                    var currentElement = int.Parse(commands[2]);
                    nums.Insert(currentIndex, currentElement);
                }
                else if (commands[0] == "contains")
                {
                    var currentElement = int.Parse(commands[1]);
                    var currentIndex = -1;
                    if (nums.Contains(currentElement))
                    {
                        currentIndex = nums.IndexOf(currentElement);
                        Console.WriteLine(currentIndex);
                    }
                    else
                    {
                        Console.WriteLine("-1");
                    }
                }
                else if (commands[0] == "remove")
                {
                    var currentIndex = int.Parse(commands[1]);
                    nums.Remove(currentIndex);
                }
                else if (commands[0] == "shift")
                {
                    var currentIndex = int.Parse(commands[1]);
                    //for (int i = 0; i < nums.Count; i++)
                    //{
                    //    //var temp = nums[i];
                    //    // //result.Add(nums[(i + currentIndex) % nums.Count]);
                    //    //       nums[i] = result[i];

                    //    //var last = nums.Count - 1;
                    //    //for (var j  = 0; j <= last; j += 1)
                    //    //{
                    //    //    nums[j] = nums[last];
                    //    //    nums[last] = nums[j];
                    //    //    nums[j] = nums[last];
                    //    //}                        
                    //}

                    // метод за ротация на ляво на масив!!!:
                    NewMethod(nums, currentIndex);

                }
                else if (commands[0] == "sumPairs")
                {
                    result = new List<int>();
                    for (int i = 1; i < nums.Count; i += 2)
                    {
                        var sum = nums[i - 1] + nums[i];
                        //nums.Remove(nums[i]);
                        result.Add(sum);
                    }
                    nums = result;
                    // сега ако дадем: result.Clear(); ще изтрие и muns!!!
                }
                else if (commands[0] == "addMany")
                {
                    var currentIndex = int.Parse(commands[1]);
                    for (int i = commands.Count-1; i >= 2; i--)
                    {
                        var currentElement = int.Parse(commands[i]);
                        nums.Insert(currentIndex, currentElement);
                    }
                    
                }
                    commands = Console.ReadLine().Split(' ').ToList();
            }
            var res = string.Join(", ", nums);
             Console.WriteLine("["+res+"]");
        }

        private static void NewMethod(List<int> nums, int currentIndex)
        {
            int numOfRotations = currentIndex;
            for (int i = 0; i < numOfRotations % nums.Count; i++)
            {
                int temp = nums[0];
                for (int j = 1; j < nums.Count; j++)
                {
                    nums[j - 1] = nums[j];
                }

                nums[nums.Count - 1] = temp;
            }
        }
    }
}
