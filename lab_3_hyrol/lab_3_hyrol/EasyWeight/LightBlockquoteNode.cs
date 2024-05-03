using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3_hyrol.EasyWeight
{
    public class LightBlockquoteNode : LightNode1
    {
        private string text;

        public LightBlockquoteNode(string text)
        {
            this.text = text;
        }

        public override void Display(int indent = 0)
        {
            Console.WriteLine($"{new string(' ', indent)}<blockquote>{text}</blockquote>");
        }

        public override int MemorySize()
        {
            return text.Length * sizeof(char);
        }
    }
}
