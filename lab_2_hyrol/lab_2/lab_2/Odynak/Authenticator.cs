using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2.Odynak
{
    public class Authenticator
    {
        private static readonly Authenticator instance = new Authenticator();
        private Authenticator() { }
        public static Authenticator GetInstance()
        {
            return instance;
        }
        public void Authenticate()
        {
            Console.WriteLine("Initialization Authenticator");

        }
    }
}
