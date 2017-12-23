using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11EqualSums
{
    class Program
    {
        static void Main()
        {
            // хъм 90/100 ???
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sumLeft = 0;
            int sumRight = 0;
            bool haveEqual = false;
            int resultInex = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sumLeft = 0;
                sumRight = 0;

                for (int j = 0; j < i; j++)
                {
                    sumLeft += nums[j];
                    if (sumRight == sumLeft)
                    {
                        haveEqual = true;
                        resultInex = i;
                        break;
                    }
                }
               
                for (int k = nums.Length-1; k > i ; k--)
                {
                    sumRight += nums[k];
                    if (sumRight == sumLeft)
                    {
                        haveEqual = true;
                        resultInex = i;
                        break;
                    }
                }                                    
             }
            if(haveEqual)
            {
                Console.WriteLine(resultInex);
            }           
             else
             {
                Console.WriteLine("no");
            }
        }
    }
}
