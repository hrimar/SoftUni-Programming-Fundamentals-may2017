using System;
using System.Collections.Generic;
using System.Linq;

namespace _05HandsOfCards
{
    class HandsOfCards
    {
        static void Main()
        {
           var input = Console.ReadLine();
            var result = new Dictionary<string, List<int>>();
            while (input != "JOKER")
            {
                var nameCards = input.Split(':');
                var name = nameCards[0];
                var cards = nameCards[1].Split(new char[] { ',', ' ' }
                , StringSplitOptions.RemoveEmptyEntries)
                .Select(card=> CardCount(card)).ToArray();
                // или var card = input.Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();

                //  var carCounts = GetVarCounts(cards);
                // така с метод за обръщане на целия масив от типове карти е сложно
                // по добре метода да севкара в .Select(a=> metod a), така за всеки тип карта да и взема и връща числената ст-ст 

              
               
                if(!result.ContainsKey(name))
                {
                    result[name] = new List<int>();
                }

                result[name].AddRange(cards); // !!! за да добави всички карти на човека
              
                
                input = Console.ReadLine(); 
            }
          
            foreach (var nameCards in result)
            {
                var name = nameCards.Key; // ако не го правя в отделна пром-ва стават грешки!!!
                var cardsSum= nameCards.Value.Distinct().Sum();
                Console.WriteLine($"{name}: {cardsSum}");
            }
            // за принтиране:               
            //foreach (var nameCards in result)
            //{
            //    Console.WriteLine($"{nameCards.Key}: {nameCards.Value.Sum()}");
            //}
        }

        private static int CardCount(string card)
        {     
            var cardPowers = new Dictionary<string, int>();
            cardPowers["J"] = 11;
            cardPowers["Q"] = 12;
            cardPowers["K"] = 13;
            cardPowers["A"] = 14;
            for (int i = 2; i < 15; i++)
            {
                cardPowers[i.ToString()] = i; //!!! [i.ToString()] -  за да гледа на 2 като на string
            }
  
            var cardType = new Dictionary<string, int>();          
                cardType["S"] = 4;
                cardType["H"] = 3;
                cardType["D"] = 2;
                cardType["C"] = 1;

    // т.е. вкарахме всички типове карти в Dict и всички бои също и правим калкукацията:    
            var cardPower = card.Substring(0, card.Length - 1);
            string cardColor = card.Substring(card.Length - 1);
   
            int calculation = cardPowers[cardPower] * cardType[cardColor]; //!!!

            return calculation;
        }
    }
}
