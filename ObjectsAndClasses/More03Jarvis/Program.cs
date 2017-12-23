using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace More03Jarvis
{
    // Неуспешен пример за ООП:
         
    class Program
    {
        static void Main()
        {
            //Leg leg = new Leg() { Energy = 20, Speed = 80, Strength = 90 };
            //Console.WriteLine(leg);
            long jarvisEnergy=long.Parse(Console.ReadLine());

            Jarvis jarvis = new Jarvis();
            jarvis.Energy = jarvisEnergy;

            while (true)
            {
                string[] tolkens = Console.ReadLine().Split();
                if(tolkens[0]=="Assemble!")
                {
                    break;
                }
                switch (tolkens[0])
                {
                    case "Head":
                        Head head = new Head()
                        {
                            Energy = int.Parse(tolkens[1]),
                            Iq=int.Parse(tolkens[2]),
                            Material=tolkens[3]
                        };
                        jarvis.AddHead(head);
                        break;
                    case "Torso":
                        Torso torso = new Torso()
                        {
                            Energy = int.Parse(tolkens[1]),
                            ProcessorSize = double.Parse(tolkens[2]),
                            Material = tolkens[3]
                        };
                        jarvis.AddTorso(torso);
                        break;
                    case "Leg":
                        Leg leg = new Leg()
                        {
                            Energy = int.Parse(tolkens[1]),
                            Strength = int.Parse(tolkens[2]),
                            Speed = int.Parse(tolkens[3])
                        };
                        jarvis.AddLeg(leg);
                        break;
                    case "Arm":
                        Arm arm = new Arm()
                        {
                            Energy = int.Parse(tolkens[1]),
                            Reach = int.Parse(tolkens[2]),
                            Fingers = int.Parse(tolkens[3])
                        };
                        jarvis.AddArm(arm);
                        break;
                }
            }
            Console.WriteLine(jarvis.ToString());
        }
    }
}
