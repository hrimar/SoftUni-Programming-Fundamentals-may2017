using System;
using System.Collections.Generic;
using System.Linq;

namespace _01CharityMarathon
{
    class Program
    {
        static void Main()
        {
            var days = int.Parse(Console.ReadLine());
            var peoples= int.Parse(Console.ReadLine());//
            var laps= int.Parse(Console.ReadLine());
            var lendOfTrack= int.Parse(Console.ReadLine());//
            var capacityOfTrack= int.Parse(Console.ReadLine());
            var moneyPerKM = double.Parse(Console.ReadLine());

            long totalPeoples = (long)capacityOfTrack * days;
            double money = 0.0;

            if (totalPeoples>peoples)
            {
                totalPeoples = peoples;
               long totalMeters = totalPeoples * laps * (long)lendOfTrack;//t
                var totalKM = totalMeters / 1000.0;
                money = totalKM * moneyPerKM;
            }
            else
            {
                long totalMeters = totalPeoples * laps * (long)lendOfTrack;//t
                var totalKM = totalMeters / 1000.0;
                money = totalKM * moneyPerKM;
            }
            Console.WriteLine($"Money raised: {money:f2}");
        }
    }
}
