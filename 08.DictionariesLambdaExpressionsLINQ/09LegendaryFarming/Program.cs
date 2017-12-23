using System;
using System.Collections.Generic;
using System.Linq;

namespace _09LegendaryFarming
{
    class Program
    {
        static void Main()
        {
            // бавно и спокойно  я довърши!!! - виж и решението долу!
            var input = Console.ReadLine().ToLower().Split().ToArray();
            var result = new Dictionary<string, int>();// Key-name, value-br
            var shadow = 0;
            var valanyr = 0;
            var dragon = 0;
            var name = string.Empty;
           
            var n = 10;
            while (n > 0)
            {
           
                for (int i = 0; i < input.Length; i++)
                {
                    var quantity = 0;
                    //if (input[i] == "shards" || input[i] == "fragments"
                    //    || input[i] == "motes")
                    //{
                    if (i % 2 == 1)
                        {
                            name = input[i];
                            quantity = int.Parse(input[i - 1]);
                        }
                        if (!result.ContainsKey(name))
                        {
                            result[name] = 0;
                        }
                        result[name] += quantity;
                    //}
                }
                string obtainElement = CheckResult(result);
                if (obtainElement != "")
                {
                    Console.WriteLine($"{obtainElement} obtained!");

                    foreach (var nameQuant in result.OrderByDescending(x => x.Value).ToArray())
                    {
                        var quant = nameQuant.Value ;
                        if(nameQuant.Value>=250)
                        {
                            quant = nameQuant.Value - 250;
                        }                            

                        Console.WriteLine($"{nameQuant.Key}: {quant}");
                    }
                }

                n--;
                input = Console.ReadLine().Split().ToArray();
            }

        }

        private static string CheckResult(Dictionary<string, int> result)
        {
            var obtainedElement = string.Empty;
            if (result.ContainsKey("shards"))
            {
                if (result["shards"] >= 250)
                {
                    obtainedElement = "Shadowmourne";
                }
            }
            if (result.ContainsKey("fragments"))
            {
                if (result["fragments"] >= 250)
                {
                    obtainedElement = "Valanyr";
                }
            }
            if (result.ContainsKey("motes"))
            {
                if (result["motes"] >= 250)
                {
                    obtainedElement = "Dragonwarath";
                }
            }
            return obtainedElement;
        }
        //static void Main(string[] args)
        //{

        //    var itemValues = new Dictionary<string, long>();
        //    itemValues.Add("fragments", 0);
        //    itemValues.Add("shards", 0);
        //    itemValues.Add("motes", 0);
        //    int count = 1;

        //    while (count != 10)
        //    {
        //        string[] inputedInfo = Console.ReadLine().ToLower().Split().ToArray();
        //        var optainedItem = "";


        //        for (int i = 1; i < inputedInfo.Length; i = i + 2)
        //        {
        //            int materialValue = int.Parse(inputedInfo[i - 1]);
        //            string material = inputedInfo[i];

        //            if (!itemValues.ContainsKey(material))
        //            {
        //                itemValues.Add(material, 0);
        //            }

        //            itemValues[material] += materialValue;

        //            //check if some of the legenderies is collected
        //            optainedItem = CheckForLegendery(itemValues);

        //            if (optainedItem != "")
        //            {
        //                Console.WriteLine($"{optainedItem} obtained!");
        //                break;
        //            }

        //        }

        //        if (optainedItem != "")
        //        {
        //            break;
        //        }
        //        count++;

        //    }

        //    PrintAllItems(itemValues);
        //}

        //private static void PrintAllItems(Dictionary<string, long> itemValues)
        //{
        //    var rareItems = itemValues.Take(3).OrderByDescending(x => x.Value).ToList();
        //    var junkItems = itemValues.Skip(3).OrderBy(x => x.Key).ToList();


        //    foreach (var rareItem in rareItems)
        //    {
        //        Console.WriteLine($"{rareItem.Key}: {rareItem.Value}");
        //    }


        //    foreach (var item in junkItems)
        //    {
        //        Console.WriteLine($"{item.Key}: {item.Value}");
        //    }


        //}

        //private static string CheckForLegendery(Dictionary<string, long> itemValues)
        //{
        //    string itemForCraft = "";
        //    if (itemValues["fragments"] >= 250)
        //    {
        //        itemForCraft = "Valanyr";
        //        itemValues["fragments"] -= 250;
        //    }

        //    if (itemValues["shards"] >= 250)
        //    {
        //        itemForCraft = "Shadowmourne";
        //        itemValues["shards"] -= 250;
        //    }

        //    if (itemValues["motes"] >= 250)
        //    {
        //        itemForCraft = "Dragonwrath";
        //        itemValues["motes"] -= 250;
        //    }

        //    return itemForCraft;
        //}
    }
}
