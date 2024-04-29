using lab_2.FactoryMethod.Subs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2.FactoryMethod.Create
{
    public class ManagerCall
    {
        public Subscription CreateSubscription(string type)
        {
            if (type.Equals("Domestic"))
            {
                return new DomesticSubscription();
            }
            else if (type.Equals("Educational"))
            {
                return new EducationalSubscription();
            }
            else if (type.Equals("Premium"))
            {
                return new PremiumSubscription();
            }
            else
            {
                throw new ArgumentException("Invalid subscription type");
            }
        }
    }
}
