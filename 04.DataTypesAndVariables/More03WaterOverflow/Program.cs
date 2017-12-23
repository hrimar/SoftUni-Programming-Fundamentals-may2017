using System;

namespace More03WaterOverflow
{
    class Program
    {
        static void Main()
        {
            // Авторско решение:
            byte pipesCount = byte.Parse(Console.ReadLine());
            byte tankCapacity = byte.MaxValue;
            byte currentTankVolume = 0;
            while (pipesCount > 0) // Така с n-- след всеки прочит намаляват с 1:
            {
                short waterVolume = short.Parse(Console.ReadLine());
                if (currentTankVolume + waterVolume <= tankCapacity)
                {
                    currentTankVolume += (byte)waterVolume;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                pipesCount--;
            }

            Console.WriteLine(currentTankVolume);


            // Мое решение 100/100:
            int n = int.Parse(Console.ReadLine());
          int currentCapacity = 0;
            for (int i = 0; i < n; i++)
            {
                int quantities = int.Parse(Console.ReadLine());

                if (currentCapacity + quantities > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                else
                {
                    currentCapacity += quantities;
                }
            }
            Console.WriteLine(currentCapacity);
        }
    }
}
