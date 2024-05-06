using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4_hyrol.Mediator
{
    class CommandCentre
    {
        private List<Runway> _runways = new List<Runway>();
        private List<Aircraft> _aircrafts = new List<Aircraft>();

        public void AddRunway(Runway runway)
        {
            _runways.Add(runway);
        }

        public void AddAircraft(Aircraft aircraft)
        {
            _aircrafts.Add(aircraft);
        }

        public void LandAircraft(Aircraft aircraft)
        {
            Runway availableRunway = GetAvailableRunway();
            if (availableRunway != null)
            {
                Console.WriteLine($"Aircraft {aircraft.Name} is landing.");
                availableRunway.IsBusyWithAircraft = aircraft;
                availableRunway.HighLightRed();
                aircraft.CurrentRunway = availableRunway;
                Console.WriteLine($"Aircraft {aircraft.Name} has landed.");
            }
            else
            {
                Console.WriteLine($"Could not land, all runways are busy.");
            }
        }

        public void TakeOffAircraft(Aircraft aircraft)
        {
            if (aircraft.CurrentRunway != null)
            {
                Console.WriteLine($"Aircraft {aircraft.Name} is taking off.");
                aircraft.CurrentRunway.IsBusyWithAircraft = null;
                aircraft.CurrentRunway.HighLightGreen();
                aircraft.CurrentRunway = null;
                Console.WriteLine($"Aircraft {aircraft.Name} has taken off.");
            }
            else
            {
                Console.WriteLine($"Could not take off, aircraft is not on any runway.");
            }
        }

        private Runway GetAvailableRunway()
        {
            foreach (var runway in _runways)
            {
                if (runway.IsBusyWithAircraft == null)
                {
                    return runway;
                }
            }
            return null;
        }
    }


}
