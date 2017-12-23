using System;
using System.Collections.Generic;
using System.Linq;

namespace More06ByteFlip
{
    class More06ByteFlip
    {
        static void Main()
        {
            var nums = Console.ReadLine().Split().Where(n => n.Length == 2).ToArray();
       //var revNums = nums.Select(n => n.Reverse()).ToString(); - така не става?!
   //Извод: за стринге не може с .Reverse() затова всяко стрингче като масивче:
            string revN = string.Empty;
            for (int i = 0; i < nums.Length; i++)
            {                
                var temp = nums[i].ToCharArray();
                Array.Reverse(temp);
                var rev = new string(temp);
                revN += rev + " ";               
            }

            var revNN=revN.Trim();
            var revCollection = revNN.Split().Reverse().ToArray();
            var decimalN = revCollection.Select(n => Convert.ToInt32(n, 16)).ToArray();
            var chars = decimalN.Select(n => (char)n).ToArray();
            Console.WriteLine(string.Join("", chars));
            
        }
    }
}
