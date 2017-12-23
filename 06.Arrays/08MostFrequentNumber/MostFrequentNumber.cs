using System;
using System.Linq;

namespace _08MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var counter = 1;
            var maxCounter = 1;
            var frequentElement = 0;
            var mostFrequentElement = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if(nums[i]==nums[j])
                    {
                        counter++;
                        frequentElement = nums[i];
                        if(counter>maxCounter)
                        {
                            maxCounter = counter;
                            mostFrequentElement = frequentElement;
                        }
                    }
                    else
                    {
                        counter = 1;
                    }                   
                }
            }
            Console.WriteLine(mostFrequentElement);
        }
    }
}
