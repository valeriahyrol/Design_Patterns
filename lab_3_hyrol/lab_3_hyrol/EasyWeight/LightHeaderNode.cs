using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3_hyrol.EasyWeight
{
    public class LightHeaderNode : LightNode1
    {
        private string text;
        private int level;

        public LightHeaderNode(string text, int level)
        {
            this.text = text;
            this.level = level;
        }

        public override void Display(int indent = 0)
        {
            Console.WriteLine($"{new string(' ', indent)}<h{level}>{text}</h{level}>");
        }

        public override int MemorySize()
        {
            return text.Length * sizeof(char);
        }
    }
}
