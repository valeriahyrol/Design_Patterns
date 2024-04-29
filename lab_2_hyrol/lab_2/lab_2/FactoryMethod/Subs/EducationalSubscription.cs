using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2.FactoryMethod.Subs
{
    public class EducationalSubscription : Subscription
    {
        public EducationalSubscription()
        {
            MonthlyFee = 15.0;
            MinimumSubscriptionPeriod = 3;
            ChannelList = new List<string> { "Educational Videos", "Tutorials" };
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Educational Subscription:");
            Console.WriteLine($"Monthly Fee: {MonthlyFee}$");
            Console.WriteLine($"Minimum Subscription Period: {MinimumSubscriptionPeriod} month(s)");
            Console.WriteLine("Channels:");
            foreach (var channel in ChannelList)
            {
                Console.WriteLine(channel);
            }
        }

    }
}
