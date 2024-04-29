using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2.FactoryMethod.Subs
{
    public class PremiumSubscription : Subscription
    {
        public PremiumSubscription()
        {
            MonthlyFee = 25.0;
            MinimumSubscriptionPeriod = 6;
            ChannelList = new List<string> { "All Channels", "Exclusive Content" };
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Premium Subscription:");
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
