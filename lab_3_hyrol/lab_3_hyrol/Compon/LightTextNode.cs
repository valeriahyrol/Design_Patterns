using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3_hyrol.Compon
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

    // Типи відображення елементів розмітки
    public enum DisplayType
    {
        Block,
        Inline
    }

    // Типи закриття елементів розмітки
    public enum ClosingType
    {
        SingleTag,
        ClosingTag
    }
}
