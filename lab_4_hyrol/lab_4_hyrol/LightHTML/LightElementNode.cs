using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4_hyrol.LightHTML
{
    public class LightElementNode : LightNode
    {
        private string tagName;
        private DisplayType displayType;
        private ClosingType closingType;
        private List<LightNode> children;
        private Dictionary<string, List<IEventListener>> eventListeners;

        public LightElementNode(string tagName, DisplayType displayType, ClosingType closingType)
        {
            this.tagName = tagName;
            this.displayType = displayType;
            this.closingType = closingType;
            this.children = new List<LightNode>();
            this.eventListeners = new Dictionary<string, List<IEventListener>>();
        }

        public void AddChild(LightNode node)
        {
            children.Add(node);
        }

        public void AddEventListener(string eventName, IEventListener listener)
        {
            if (!eventListeners.ContainsKey(eventName))
            {
                eventListeners[eventName] = new List<IEventListener>();
            }
            eventListeners[eventName].Add(listener);
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

        public void TriggerEvent(string eventName)
        {
            if (eventListeners.ContainsKey(eventName))
            {
                foreach (var listener in eventListeners[eventName])
                {
                    listener.HandleEvent(eventName);
                }
            }
        }

        private List<string> GetCssClasses()
        {
            return new List<string>();
        }
    }
}
