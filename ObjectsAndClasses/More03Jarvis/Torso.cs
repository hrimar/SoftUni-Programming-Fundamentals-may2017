using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More03Jarvis
{
    class Torso
    {
        public int Energy { get; set; }
        public double ProcessorSize { get; set; }
        public string Material { get; set; }

        public override string ToString()
        {
            string result = string.Empty;
            result += "#Torso:\r\n";
            result += "###Energy consumption: " + Energy + "\r\n";
            result += string.Format($"###Processor size: {ProcessorSize:f1}\r\n");
            result += string.Format($"###Corpus material: {Material}\r\n");
            return result;
        }
    }
}
