using System;

namespace lab_4_hyrol.Mediator
{
    class Runway
    {
        public readonly Guid Id = Guid.NewGuid();
        public Aircraft? IsBusyWithAircraft;

        public void HighLightRed()
        {
            Console.WriteLine($"Runway {Id} is busy!");
        }

        public void HighLightGreen()
        {
            Console.WriteLine($"Runway {Id} is free!");
        }
    }
}
