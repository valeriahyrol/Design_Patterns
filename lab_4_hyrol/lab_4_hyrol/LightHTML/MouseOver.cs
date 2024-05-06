using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4_hyrol.LightHTML
{
    class MouseOver : IEventListener
    {
        public void HandleEvent(string eventName)
        {
            Console.WriteLine($"Mouseover event handled: {eventName}");
        }
    }
}
