using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace more05BPMCounter
{
    class Program
    {
        static void Main()
        {
            var beatsPerMin = int.Parse(Console.ReadLine());
            var beats = int.Parse(Console.ReadLine()); // 1 bar== 4 beats
            var bars = beats / 4.0;
            var seconds = beats * 60/beatsPerMin;
            var minutes = seconds / 60;
            if(seconds>59)
            {
                seconds = seconds;
            }
            Console.WriteLine($"{Math.Floor(bars)} bars - {minutes}m {seconds}s");

        }
    }
}
