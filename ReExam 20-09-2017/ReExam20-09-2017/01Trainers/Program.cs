using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Trainers
{
    class Program
    {
        static void Main()
        {
            var n = long.Parse(Console.ReadLine());
            var participantEarnedMoney = 0.0m;
            var totalMoneyOfTechnical = 0.0m;
            var totalMoneyOfPractical = 0.0m;
            var totalMoneyOfTheoretical = 0.0m;
            for (int i = 0; i < n; i++)
            {
                var distance = long.Parse(Console.ReadLine());
                var tons = double.Parse(Console.ReadLine());
                var team = Console.ReadLine();

                var mDistance = 1600.0m * (decimal)distance;
                var kilograms = 1000.0m * (decimal)tons;

                var fuelExpences = (0.7m * 2.5m * mDistance);
                var cargoIncome = (1.5m * kilograms);

                //
                participantEarnedMoney = cargoIncome - fuelExpences;
                //}



                if (team == "Technical")
                {
                    totalMoneyOfTechnical += participantEarnedMoney;
                }
                else if (team == "Theoretical")
                {
                    totalMoneyOfTheoretical += participantEarnedMoney;
                }
                else if (team == "Practical")
                {
                    totalMoneyOfPractical += participantEarnedMoney;
                }

            }
            //var max = Math.Max(totalMoneyOfTechnical, totalMoneyOfPractical);
            //var theBestMax = Math.Max(max, totalMoneyOfTheoretical);

            if(totalMoneyOfTechnical > totalMoneyOfPractical && totalMoneyOfTechnical > totalMoneyOfTheoretical)
            {
                Console.WriteLine($"The Technical Trainers win with ${totalMoneyOfTechnical:f3}.");
            }
            else if (totalMoneyOfPractical > totalMoneyOfTechnical && totalMoneyOfPractical > totalMoneyOfTheoretical)
            {
                Console.WriteLine($"The Practical Trainers win with ${totalMoneyOfPractical:f3}.");
            }
            else
            {
                Console.WriteLine($"The Theoretical Trainers win with ${totalMoneyOfTheoretical:f3}.");
            }

        }
    }
}
