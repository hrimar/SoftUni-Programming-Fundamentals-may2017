using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More03Jarvis
{
    class Leg
    {
        public int Energy { get; set; }
        public int Strength { get; set; }
        public int Speed { get; set; }

        public override string ToString()
        {
            //целта е да си презапишем метота ToString така, че да ни върне желано от нас нещо
            string result = string.Empty;
            result += "#Leg:\r\n";
            result += "###Energy consumption: " + Energy + "\r\n";
            result += string.Format($"###Strength: {Strength}\r\n");
            result += string.Format($"###Speed: {Speed}\r\n");
            return result;
        }
    }
}
