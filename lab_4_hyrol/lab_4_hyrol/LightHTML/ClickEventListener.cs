using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4_hyrol.LightHTML
{
    public class ClickEventListener : IEventListener
    {
        public void HandleEvent(string eventName) => Console.WriteLine($"Click event handled: {eventName}");
    }
}