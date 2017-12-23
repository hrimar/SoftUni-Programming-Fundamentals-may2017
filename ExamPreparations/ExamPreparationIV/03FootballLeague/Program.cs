using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03FootballLeague
{
    class Score // resulttat
    {       
        public int Points { get; set; }
        public int Goals { get; set; }
    }
    class FootballLeague
    {
        static void Main()
        {
            // Mi 70/100:
            var key = Regex.Escape(Console.ReadLine());
            // това е заради разликите м/у C# и RgeEx (символи като ?, {, | )
            var teamList = new Dictionary<string, Score>();
            var points1 = 0;
            var points2 = 0;

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "final")
                {
                    break;
                }
                // .+?(?<key>{key})(?<team1>\w+)(\k<key>)(?:.+)?(\k<key>)(?<team2>\w+)(\k<key>)(?:.+)? (?<result>\d:\d)
                
                var pattern = $@"^.*(?<key>{key})(?<team1>[a-zA-Z]*)(\k<key>)(?:.*) .*(\k<key>)(?<team2>[a-zA-Z]*)(\k<key>)(?:.+)? (?<result>\d:\d)";
                var regex = Regex.Match(input, pattern);

                var team1 = new string(regex.Groups["team1"].Value.ToUpper().Reverse().ToArray());
                var team2 = new string(regex.Groups["team2"].Value.ToUpper().Reverse().ToArray());
                var result = regex.Groups["result"].Value.Split(':').ToArray();
                var goals1 = int.Parse(result[0]);
                var goals2 = int.Parse(result[1]);
                                
                // В речника 1 след друг правим нови класове
                if(!teamList.ContainsKey(team1) )
                {
                    teamList[team1] = new Score();
                }
                if (!teamList.ContainsKey(team2))
                {
                    teamList[team2] = new Score();
                }
                // и вече щом сме инициализирали нов клас го пълним така:
                teamList[team1].Goals += goals1;
                teamList[team2].Goals += goals2;


                if (goals1 > goals2)
                {
                    teamList[team1].Points += 3;
                }
                else if (goals1 < goals2)
                {
                    teamList[team2].Points += 3;
                }
                else if (goals2 == goals1)
                {
                    teamList[team2].Points += 1;
                    teamList[team1].Points += 1;
                }

                
            }
          
            Console.WriteLine("League standings:");
            var sortedTeams = teamList.OrderByDescending(a => a.Value.Points).ThenBy(a => a.Key).ToArray();
            for (int i = 0; i < sortedTeams.Length; i++)
            {           
                Console.WriteLine($"{i+1}. {sortedTeams[i].Key} {sortedTeams[i].Value.Points}");               
            }


            //var i = 1;
            // Console.WriteLine("League standings:");
            //foreach (var item in teamList.OrderByDescending(a=>a.Value.Points).ThenBy(a=>a.Key))
            //{
            //    Console.WriteLine($"{i}. {item.Key} {item.Value.Points}");
            //    i++;
            //}

            Console.WriteLine("Top 3 scored goals:");
            foreach (var item in teamList.OrderByDescending(a=>a.Value.Goals).Take(3))
            {
                Console.WriteLine($"- {item.Key} -> {item.Value.Goals}");
            }

        }
    }
}

