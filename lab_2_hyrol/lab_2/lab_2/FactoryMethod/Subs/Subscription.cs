using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2.FactoryMethod.Subs
{
    public abstract class Subscription
    {
        public double MonthlyFee { get; protected set; }
        public int MinimumSubscriptionPeriod { get; protected set; }
        public List<string> ChannelList { get; protected set; }

        public abstract void DisplayInfo();
    }
}
