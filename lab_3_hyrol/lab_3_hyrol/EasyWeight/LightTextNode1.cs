using lab_3_hyrol.Compon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace lab_3_hyrol.EasyWeight
{
    public class LightTextNode1 : LightNode1
    {
        private string text;

        public LightTextNode1(string text)
        {
            this.text = text;
        }

        public override void Display(int indent = 0)
        {
            Console.WriteLine($"{new string(' ', indent)}<p>{text}</p>");
        }

        public override int MemorySize()
        {
            return text.Length * sizeof(char);
        }
    }
}

