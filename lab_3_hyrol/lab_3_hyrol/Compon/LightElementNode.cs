using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3_hyrol.Compon
{
    public class LightElementNode : LightNode
    {
        private string tagName;
        private DisplayType displayType;
        private ClosingType closingType;
        private List<LightNode> children;

        public LightElementNode(string tagName, DisplayType displayType, ClosingType closingType)
        {
            this.tagName = tagName;
            this.displayType = displayType;
            this.closingType = closingType;
            this.children = new List<LightNode>();
        }

        public void AddChild(LightNode node)
        {
            children.Add(node);
        }

        public override void Display()
        {
            Console.WriteLine($"<{tagName} class=\"{string.Join(" ", GetCssClasses())}\" style=\"display: {(displayType == DisplayType.Block ? "block" : "inline")}\">");
            foreach (var child in children)
            {
                child.Display();
            }
            if (closingType == ClosingType.ClosingTag)
            {
                Console.WriteLine($"</{tagName}>");
            }
            else
            {
                Console.WriteLine($"<{tagName}/>");
            }
        }

        private List<string> GetCssClasses()
        {
            return new List<string>();
        }
    }

}
