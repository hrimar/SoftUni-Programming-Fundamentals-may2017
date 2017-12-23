using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02ChangeList
{
    class Program
    {
       static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var commands = Console.ReadLine().Split(' ').ToList();
            var result = new List<int>();

            while (commands[0] != "Odd" && commands[0] != "Even") // ! или едото или другото !
            {
                if (commands[0] == "Insert")
                {
                    var currentIndex = int.Parse(commands[2]);
                    var currentElement = int.Parse(commands[1]);
                    nums.Insert(currentIndex, currentElement);
                }
                else if (commands[0] == "Delete")
                {
                    var currentElement = int.Parse(commands[1]);
                    for (int i = 0; i < nums.Count; i++)
                    {
                        if(nums[i]==currentElement)
                        {
                            nums.Remove(nums[i]);
                            i = i - 1;
                        }
                    }
                }
                commands = Console.ReadLine().Split(' ').ToList();
            }

            if (commands[0] == "Odd")
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    if(nums[i]%2==1)
                    {
                        result.Add(nums[i]);
                    }                   
                }
            }
            else if (commands[0] == "Even")
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    if (nums[i] % 2 == 0)
                    {
                        result.Add(nums[i]);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
