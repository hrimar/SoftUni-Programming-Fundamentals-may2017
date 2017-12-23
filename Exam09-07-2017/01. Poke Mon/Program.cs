using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Poke_Mon
{
    class Program
    {
        static void Main()
        {
            // много интове, внимавай пак се полуюава инт!!!
            var powerN = int.Parse(Console.ReadLine());
            var distanceM = int.Parse(Console.ReadLine());
            var factor = int.Parse(Console.ReadLine());
            var count = 0;
       
            decimal percent50 = (decimal)powerN / 2.0m;
            while (powerN >= distanceM)
            {
                count++;
                powerN = powerN - distanceM;
                if ((decimal)powerN == percent50) // 50% tochno!
                {
                    if (factor == 0)
                    {
                        powerN -= distanceM;
                    }
                    else
                    {
                        powerN = powerN / factor;
                    }
                }

            }
            Console.WriteLine($"{powerN}");
            Console.WriteLine(count);


        }
    }
}
