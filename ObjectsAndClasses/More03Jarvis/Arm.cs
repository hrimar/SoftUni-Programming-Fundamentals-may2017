using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More03Jarvis
{
    class Arm
    {
        public int Energy { get; set; }
        public int Reach { get; set; }
        public int Fingers { get; set; }

        public override string ToString()
        {
            string result = string.Empty;
            result += "#Arm:\r\n";
            result += "###Energy consumption: " + Energy + "\r\n";
            result += string.Format($"###Reach: {Reach}\r\n");
            result += string.Format($"###Fingers: {Fingers}\r\n");
            return result;
        }
    }
}
