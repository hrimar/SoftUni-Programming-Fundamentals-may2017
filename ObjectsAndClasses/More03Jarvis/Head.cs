using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More03Jarvis
{
    class Head
    {
        public int Energy { get; set; }
        public int Iq { get; set; }
        public string Material { get; set; }

        public override string ToString()
        {
            string result = string.Empty;
            result += "#Head:\r\n";
            result += "###Energy consumption: " + Energy + "\r\n";
            result += string.Format($"###IQ: {Iq}\r\n");
            result += string.Format($"###Skin material: {Material}\r\n");
            return result;
        }
    }
}
