using lab_3_hyrol.Compon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3_hyrol.EasyWeight
{
    public class HTMLPage
    {
        private List<LightNode1> nodes;

        public HTMLPage()
        {
            nodes = new List<LightNode1>();
        }

        public void AddNode(LightNode1 node)
        {
            nodes.Add(node);
        }

        public void DisplayPage()
        {
            int totalMemorySize = 0;

            foreach (var node in nodes)
            {
                node.Display();
                totalMemorySize += node.MemorySize();
            }

            Console.WriteLine($"Total memory size of the HTML tree: {totalMemorySize} bytes");
        }
    }
}
