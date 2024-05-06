using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4_hyrol.Mediator
{
    class Aircraft
    {
        public string Name { get; }
        public Runway? CurrentRunway { get; set; }

        public Aircraft(string name)
        {
            Name = name;
        }
    }
}

