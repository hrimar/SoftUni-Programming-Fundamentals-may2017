using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Entertrain
{
    class Program
    {
        static void Main()
        {
            
            List<int> vagons = new List<int>();
            var power = int.Parse(Console.ReadLine());

            while (true)
            {               
              
                var input = Console.ReadLine();
                if (input == "All ofboard!")
                {
                    
                    break;
                }
               var vagon = int.Parse(input);
                vagons.Add(vagon);
                var sum = vagons.Sum();

            if (sum>power)
                {
                    var average = vagons.Average();

                    var intAverage = (int)average; // ?? Math.Floor?

                    // махаме най-близкия до average елемент!!!
                    var newVagons = vagons.ToArray();
                    int closest = newVagons
                        .OrderBy(item => Math.Abs(intAverage - item))
                        .First();

                    //int closest = vagons.
                    //    Aggregate((x, y) => Math.Abs(x - intAverage) < Math.Abs(y - intAverage) ? x : y);

                    //int closest = 0;
                    //for (int i = 0; i < vagons.Count; i++)
                    //{
                    //    if(intAverage == vagons[i])
                    //    {
                    //        closest = vagons[i];
                    //    }
                    //}

                    vagons.Remove(closest);

                    
                }


            }
            
                 vagons.Reverse();
                vagons.Add(power);
                Console.WriteLine(string.Join(" ", vagons));
           


        }
    }
}
