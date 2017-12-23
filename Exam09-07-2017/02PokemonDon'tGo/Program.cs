using System;
using System.Collections.Generic;
using System.Linq;

namespace _02PokemonDon_tGo
{
    class Program
    {
        static void Main()
        {
            var nums = Console.ReadLine()
                .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            var index = int.Parse(Console.ReadLine());


            var numsList = nums.ToList();
            if(index>=0 && index<=nums.Length-1)
            {
                numsList.RemoveAt(index);
                    
                    
                    }

        }
    }
}
