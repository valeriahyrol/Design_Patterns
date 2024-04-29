using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2.FactoryMethod.Subs
{
    public class DomesticSubscription : Subscription
    {
        public DomesticSubscription()
        {
            MonthlyFee = 10.0;
            MinimumSubscriptionPeriod = 1;
            ChannelList = new List<string> { "Domestic News", "Domestic Entertainment" };
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Domestic Subscription:");
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
