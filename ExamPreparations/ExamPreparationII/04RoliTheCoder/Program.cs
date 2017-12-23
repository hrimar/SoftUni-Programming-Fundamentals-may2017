using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04RoliTheCoder
{
    class Event
    {   
        public string Name { get; set; }
        public List<string> Participants { get; set; }
    }
    class Program
    {
        static void Main()
        {

            // 70/100
            //var input = Console.ReadLine();
            //var result = new Dictionary<string, List<string>>();
            //var idEvent = new Dictionary<int, string>();
            //while (input!= "Time for Code")
            //{
            //    var inputData = Regex.Split(input, @"\s+").ToArray();
            //    var id = int.Parse(inputData[0]);
            //    var eventName = inputData[1].Substring(1);

            //    if(!idEvent.ContainsKey(id))
            //    {
            //     idEvent[id] = eventName;
            //    }

            //    if (!result.ContainsKey(eventName) && eventName == idEvent[id])
            //    {
            //        result[eventName] = new List<string>();


            //        for (int i = 2; i < inputData.Length; i++)
            //        {
            //            if (inputData[i][0] == '@')
            //            {
            //                if (!result[eventName].Contains(inputData[i]))
            //                    result[eventName].Add(inputData[i]);
            //            }
            //        }
            //    }
            //    if (result.ContainsKey(eventName) && eventName == idEvent[id])
            //    {
            //        for (int i = 2; i < inputData.Length; i++)
            //        {
            //            if (inputData[i][0] == '@')
            //            {
            //                if (!result[eventName].Contains(inputData[i]))
            //                    result[eventName].Add(inputData[i]);
            //            }
            //        }
            //    }
            //        input = Console.ReadLine();
            //}

            //foreach (var res in result.OrderByDescending(a=>a.Value.Count))
            //{
            //    Console.WriteLine($"{res.Key} - {res.Value.Count}");
            //    foreach (var item in res.Value.OrderBy(a=>a))
            //    {
            //        Console.WriteLine(item);
            //    }
            //}


            // Хитро решение 2: -  недовършено
            // с Regex да вземем всички данни и която са с № са евент, които са @ - име

            //var eventRegex = new Regex(@"(?<id>\d+) #(?<eventName>\w+)\s+(?<participants>(@[a-zA-Z-]+\s*)*)");

            //var input = Console.ReadLine();
            //var result = new Dictionary<string, Event>();

            //while (input != "Time for Code")
            //{
            //   var eventMatch = eventRegex.Match(input);
            //    if(!eventMatch.Success)
            //    {
            //        continue;
            //    }
            //    var id = int.Parse(eventMatch.Groups["id"].Value);
            //    var eventName = eventMatch.Groups["eventName"].Value;
            //    var participantsStr = eventMatch.Groups["participants"].Value;

            //    var participants = new List<string>();

            //    if(participantsStr.Length>0)
            //    {
            //        participants.AddRange(participantsStr.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            //    }

            //    if (!result.ContainsKey(id))
            //    {
            //        var @event = new Event
            //        {
            //            Name = eventName,
            //            Participants = participants
            //        };
            //        result[id] = @event;
            //    }

            //    if(result[id].Name==eventName)
            //    {
            //        result[id].Participants.AddRange(participants);
            //    }
            //    input = Console.ReadLine();
            //}

            //................

        }
    }
}
