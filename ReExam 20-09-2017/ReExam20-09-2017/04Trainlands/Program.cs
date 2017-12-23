//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;

//namespace _04Trainlands
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var result = new Dictionary<string, Dictionary<string, int>>();

//            while (true)
//            {
//                var input = Console.ReadLine();
//                if (input == "It's Training Men!")
//                {
//                    break;
//                }

//                if (input.Contains(':'))
//                {
//                    var inputDetails = Regex.Split(input, @"\s->\s*").ToArray();
//                    var train = inputDetails[0];
//                    var restTrain = inputDetails[1];
//                    var vagonPower = Regex.Split(restTrain, @"\s:\s*").ToArray();
//                    var vagon = vagonPower[0];
//                    var power = int.Parse(vagonPower[1]);

//                    if (!result.ContainsKey(train))
//                    {
//                        result[train] = new Dictionary<string, int>();
//                    }
//                    result[train][vagon] = power;

//                }
//                else if (input.Contains('='))
//                {
//                    var details = Regex.Split(input, @"\s=\s*").ToArray();
//                    var newTrain = details[0];
//                    var oldTrain = details[1];

//                    if (!result.ContainsKey(newTrain))
//                    {
//                        result[newTrain] = new Dictionary<string, int>();

//                    }
//                    else
//                    {
//                       // result[newTrain] += result[oldTrain];
//                        {
//                            foreach (var item in result[oldTrain])
//                            {
//                                result[newTrain] = result[oldTrain];
                          
//                            }
//                        }
//                    }
//                    //result[train]

//                }
//                else if (input.Contains('-'))
//                {
//                    var details = Regex.Split(input, @"\s->\s*").ToArray();
//                    var newTrain = details[0];
//                    var oldTrain = details[1];
//                    if (!result.ContainsKey(newTrain))
//                    {
//                        result[newTrain] = new Dictionary<string, int>();

//                        result[newTrain] = result[oldTrain];
//                        //result[oldTrain].Clear();
//                    }
//                    else
//                    {
//                        foreach (var item in result[oldTrain])
//                        {
                            
//                            foreach (var newT in result[newTrain])
//                            {
//                                if (item.Key == newT.Key)
//                                {
//                                    newT.Value.Add item.Value;
//                                        }
//                            }
//                        }
//                    }
//                }
//                }
//            foreach (var trainVagonCount in result
//                .OrderByDescending(a=>a.Value.Values.Sum()).
//                ThenBy(a=>a.Value.Values.Count()))
//            {
//                Console.WriteLine($"Train: {trainVagonCount.Key}");
//                foreach (var item in trainVagonCount.Value)
//                {
//                    Console.WriteLine($"###{item.Key} - {item.Value}");
//                }
//            }

//        }

//    }
//}
