using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_hyrol.money { 

        public class MoneyUSD
        {
            public int Dollars { get; set; }
            public int Cents { get; set; }

            public MoneyUSD(int dollars, int cents)
            {
                Dollars = dollars;
                Cents = cents;
            }

            public void PrintAmountUSD()
            {
                Console.WriteLine($"Amount: {Dollars}.{Cents} USD");
            }
        }

        public class MoneyUAH
        {
            public int Hryvnas { get; set; }
            public int Kopiykas { get; set; }

            public MoneyUAH(int hryvnas, int kopiykas)
            {
                Hryvnas = hryvnas;
                Kopiykas = kopiykas;
            }

            public void PrintAmountUAH()
            {
                Console.WriteLine($"Amount: {Hryvnas}.{Kopiykas} UAH");
            }
        }
    }

