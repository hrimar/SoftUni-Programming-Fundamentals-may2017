using System;
using System.Collections.Generic;
using System.Linq;

namespace More06Heists
{
    class More06Heists
    {
        static void Main()
        {
            var jewelsGoldPrice = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            long expences = 0;
           long totalEarning = 0;
            int jewelsPrice = 0; 
            int goldPrice = 0; 

            while (true)
            {
                var info = Console.ReadLine().Split(' ').ToArray();

                if(info[0] == "Jail" && info[1] == "Time")
                {
                    break;
                }
                string loot = info[0];              
             
               expences += long.Parse(info[1]);//50 10 10

                for (int i = 0; i < loot.Length; i++)
                {                    
                    if (loot[i]=='%')
                    {
                        jewelsPrice+= jewelsGoldPrice[0];
                     
                    }
                    else if (loot[i]=='$')
                    {                       
                        goldPrice+=jewelsGoldPrice[1];
                    }
                }            
            }
            totalEarning = (jewelsPrice + goldPrice);
            long difference = Math.Abs(totalEarning-expences);
         
            if(totalEarning>=expences)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {difference}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {expences-totalEarning}.");
            }
        }
    }
}
