using System;


class Program
{
    static void Main()
    {
        // бреее 71/100 Да видя решението!???!
        int peshoDamage = int.Parse(Console.ReadLine());
        int goshoDamage = int.Parse(Console.ReadLine());
        var peshoHealthPoints = 100;
        var goshoHealthPoints = 100;
        var counter = 0;

        while (peshoHealthPoints > 0 && goshoHealthPoints >0)
        {
            if (counter % 3 == 0 && counter != 0)
            {
                goshoHealthPoints += 10;
                peshoHealthPoints += 10;
            }
            goshoHealthPoints = goshoHealthPoints - peshoDamage;
            if (goshoHealthPoints <= 0)                  break;
            else if (peshoHealthPoints <= 0)             break;
                       
            Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealthPoints} health.");
            counter++;
            peshoHealthPoints = peshoHealthPoints - goshoDamage;
            
            if (goshoHealthPoints  <= 0)        break;
            else if (peshoHealthPoints  <= 0)      break;
          
            if (counter % 3 == 0 && counter != 0)
            {
                goshoHealthPoints += 10;
                peshoHealthPoints += 10;
            }
            Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealthPoints} health.");
            counter++;

            if (goshoHealthPoints <= 0)              break;       
            else if (peshoHealthPoints <= 0)       break;        
            
        }
        if (goshoHealthPoints  <= 0)
        {
            Console.WriteLine($"Pesho won in {counter+1}th round.");
        }
        else if (peshoHealthPoints <= 0)
        {
            Console.WriteLine($"Gosho won in {counter+1}th round.");
        }
    }
}

