using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDonGo
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                    .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
            var index = int.Parse(Console.ReadLine());
            var sum = 0;
            var removedElement = 0;
            var numsList = nums.ToList();

            while (numsList.Count > 0)
            {
                if (index >= 0 && index <= (numsList.Count - 1))
                {
                    removedElement = numsList[index];
                    numsList.RemoveAt(index);

                    for (int i = 0; i < numsList.Count; i++)
                    {
                        if (numsList[i] <= removedElement)
                        {
                            numsList[i] += removedElement;
                        }
                        else if (numsList[i] > removedElement)
                        {
                            //numsList = numsList.Select(n => n - removedElement).ToList();
                            numsList[i] -= removedElement;
                        }
                    }
                }
                else if (index < 0)
                {
                    removedElement = numsList[0];
                    numsList.RemoveAt(0);
                    numsList.Insert(0, numsList[numsList.Count - 1]);

                    for (int i = 0; i < numsList.Count; i++)
                    {
                        if (numsList[i] <= removedElement)
                        {
                            numsList[i] += removedElement;
                        }
                        else if (numsList[i] > removedElement)
                        {
                            //numsList = numsList.Select(n => n - removedElement).ToList();
                            numsList[i] -= removedElement;
                        }
                    }
                }
                else if (index > numsList.Count - 1)
                {
                    removedElement = numsList[numsList.Count - 1];
                    numsList[numsList.Count - 1]= numsList[0];
                    //numsList.RemoveAt(numsList.Count - 1);
                    //numsList.Insert(numsList.Count - 1, numsList[0]);

                    for (int i = 0; i < numsList.Count; i++)
                    {
                        if (numsList[i] <= removedElement) //??
                        {
                            numsList[i] += removedElement;
                        }
                        else if (numsList[i] > removedElement)
                        {
                            //numsList = numsList.Select(n => n - removedElement).ToList();
                            numsList[i] -= removedElement;
                        }
                    }
                }
                sum += removedElement;

                if (numsList.Count==0)
                {
                    break;
                }
                else
                {
   // Console.WriteLine(string.Join(" ", numsList));
                 index = int.Parse(Console.ReadLine());
                }
               
            
            }
            Console.WriteLine(sum);
        }

        }
    }
