using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();

            var phoneBook = new Dictionary<string, string>(); // key=input[1], value=input[2]

            while (input[0]!="END")
            {
                var addOrSearch = input[0];
                var name= input[1];
               

                if (addOrSearch=="A")
                {
                    var phone = input[2];
                    phoneBook[name] = phone;
                }
                else if (addOrSearch == "S")
                {
                    if(phoneBook.ContainsKey(name))
                    {
                        Console.WriteLine(name + " -> " + phoneBook[name]);
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }

                input = Console.ReadLine().Split().ToArray();
            }

            //foreach (var item in phoneBook)
            //{
            //    Console.WriteLine(item.Key+" -> "+item.Value);
            //}
        }
    }
}
