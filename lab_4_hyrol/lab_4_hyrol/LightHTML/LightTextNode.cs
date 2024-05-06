using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4_hyrol.LightHTML
{
    public class LightTextNode : LightNode
    {
        private string text;

        public LightTextNode(string text)
        {
            this.text = text;
        }

        public override void Display()
        {
            Console.WriteLine(text);
        }
    }

    public enum DisplayType
    {
        Block,
        Inline
    }

    public enum ClosingType
    {
        SingleTag,
        ClosingTag
    }
}

