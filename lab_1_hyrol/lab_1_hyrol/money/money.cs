using System;

public class Money
{
    public int Dollars { get; set; }
    public int Cents { get; set; }
    public int Hryvnas { get; set; }
    public int Kopiykas { get; set; }

    public Money()
    {
        Dollars = 0;
        Cents = 0;
        Hryvnas = 0;
        Kopiykas = 0;
    }

    public Money(int dollars, int cents)
    {
        Dollars = dollars;
        Cents = cents;
    }

    public Money(int hryvnas, int kopiykas, bool isUah = true)
    {
        Hryvnas = hryvnas;
        Kopiykas = kopiykas;
    }

    public void PrintAmountUSD()
    {
        Console.WriteLine($"Amount: {Dollars}.{Cents} USD");
    }

    public void PrintAmountUAH()
    {
        Console.WriteLine($"Amount: {Hryvnas}.{Kopiykas} UAH");
    }
}

