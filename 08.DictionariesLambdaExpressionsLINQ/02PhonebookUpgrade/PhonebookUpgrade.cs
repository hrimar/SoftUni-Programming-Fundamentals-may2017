using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02PhonebookUpgrade
{
    class PhonebookUpgrade
    {        
            static void Main(string[] args)
        {
                var input = Console.ReadLine().Split().ToArray();

                var phoneBook = new SortedDictionary<string, string>(); // key=input[1], value=input[2]

                while (input[0] != "END")
                {
                    var addOrSearch = input[0];                   

                    if (addOrSearch == "A")
                    {
                    var name = input[1];
                    var phone = input[2];
                        phoneBook[name] = phone;
                    }
                    else if (addOrSearch == "S")
                    {
                    var name = input[1];
                    if (phoneBook.ContainsKey(name))
                        {
                            Console.WriteLine(name + " -> " + phoneBook[name]);
                        }
                        else
                        {
                            Console.WriteLine($"Contact {name} does not exist.");
                        }
                    }
                    else if (addOrSearch == "ListAll")
                {
                    foreach (var item in phoneBook)
                    {
                        Console.WriteLine(item.Key + " -> " + item.Value);
                    }
                }

                input = Console.ReadLine().Split().ToArray();
                }

               
            }
        }
}
