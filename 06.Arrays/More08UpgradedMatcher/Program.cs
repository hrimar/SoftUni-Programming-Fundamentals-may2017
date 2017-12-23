using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More08UpgradedMatcher
{
    class Program
    {
        static void Main(string[] args)
        {            

            // да я довърша!!!

            var names = Console.ReadLine().Split(' ').ToArray();
            var quantities = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            var prices = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

            var nameOrder = Console.ReadLine().Split(' ').ToArray();
            string name = nameOrder[0];

            if(nameOrder.Length==1)
            {
                int quantitiOrder = int.Parse(nameOrder[1]);
            }        

            while (nameOrder[0] != "done")
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (nameOrder[0] == names[i])
                    {
                        Console.WriteLine
          ($"{nameOrder} costs: {prices[i]}; Available quantity: {quantities[i]}");
                    }
                }
                name = Console.ReadLine();
            }

        }
    }
}
