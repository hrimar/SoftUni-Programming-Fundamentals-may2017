using System;
using System.Collections.Generic;
using System.Linq;

namespace More03ImmuneSystem
{
    class Program
    {
        static void Main()
        {
            // aman от обяснения
            var viruses = new Dictionary<string, int>();
            var healt = int.Parse(Console.ReadLine());
            var virus = Console.ReadLine();

            while (virus != "end")
            {
                var virusPower = CalculateVirusPower(virus);
                int maxHelt = healt;
                var virusTime = (int)(Math.Floor((double)virusPower * virus.Length));
                var timeDefeatMin=CalcDfeatMin(virusTime);//
  
                if(viruses.ContainsKey(virus))
                {
                    virusTime = (int)(virusTime / 3.0); 
                }
                else
                {
                    viruses[virus] = virusTime;
                }
                Console.WriteLine($"Virus {virus}: {virusPower} => {virusTime} seconds");

                healt -= virusTime;
                if(healt<=0)
                {
                    Console.WriteLine("Immune System Defeated.");
                    return;
                }
                else
                {
                    Console.WriteLine($"{virus} defeated in {CalcDfeatMin(virusTime)}.");
                    Console.WriteLine($"Remaining health: {healt}");
                }
                healt = Math.Min(maxHelt, (int)(healt * 1.2)); // za da uvelich 20%
                virus = Console.ReadLine();
            }
            Console.WriteLine($"Final Health: " + healt);
        }

        private static string CalcDfeatMin(double timeDefeatSec)
        {
            var  seconds= timeDefeatSec % 60;
            var minutes = timeDefeatSec / 60;
           
            return ($"{Math.Floor(minutes)}m {seconds}s");
           
        }

        private static int CalculateVirusPower(string virus)
        {
            var count = 0.0;
            for (int i = 0; i < virus.Length; i++)
            {
                count+= (int)virus[i];
            }
            return (int)Math.Floor(count/ 3);
        }
    }
}
