using lab_2.FactoryMethod.Create;
using lab_2.FactoryMethod.Subs;
using lab_2.TechFactory.Brands;
using lab_2.TechFactory.Products;
using lab_2.TechFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab_2.Odynak;
using lab_2.Prototype;
using lab_2.Builder;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Task1");
        WebSite webSite = new WebSite();
        Subscription webSubscription = webSite.CreateSubscription("Premium");
        Console.WriteLine("Subscription created with Website:");
        webSubscription.DisplayInfo();
        Console.WriteLine();

        MobileApp mobileApp = new MobileApp();
        Subscription mobileSubscription = mobileApp.CreateSubscription("Domestic");
        Console.WriteLine("Subscription created with Mobile App:");
        mobileSubscription.DisplayInfo();
        Console.WriteLine();

        ManagerCall managerCall = new ManagerCall();
        Subscription managerSubscription = managerCall.CreateSubscription("Educational");
        Console.WriteLine("Subscription created with Manager Call:");
        managerSubscription.DisplayInfo();

        Console.WriteLine();
        Console.WriteLine("Task2");
        Tech_Factory factory = new Tech_Factory();

        Brand brand1 = factory.CreateBrand("IProne");
        Brand brand2 = factory.CreateBrand("Kiaomi");
        Brand brand3 = factory.CreateBrand("Balaxy");

        Device device1 = brand1.CreateDevice();
        Device device2 = brand2.CreateDevice();
        Device device3 = brand3.CreateDevice();

        Console.WriteLine($"Brand: {brand1.Name}, Device: {device1.Name}, Screen Size: {device1.ScreenSize}, Processor: {device1.Processor}");
        Console.WriteLine($"Brand: {brand2.Name}, Device: {device2.Name}, Screen Size: {device2.ScreenSize}, Processor: {device2.Processor}");
        Console.WriteLine($"Brand: {brand3.Name}, Device: {device3.Name}, Screen Size: {device3.ScreenSize}, Processor: {device3.Processor}");

        Console.WriteLine();
        Console.WriteLine("Task3");
        Authenticator authenticator1 = Authenticator.GetInstance();
        Authenticator authenticator2 = Authenticator.GetInstance();

        if (authenticator1 == authenticator2)
        {
            Console.WriteLine("authenticator1 & authenticator2 посилаються на один & той же екземпляр");
        }
        else
        {
            Console.WriteLine("authenticator1 & authenticator2 НЕ посилаються на один & той же екземпляр");
        }

        Console.WriteLine();
        Console.WriteLine("Task4");
        Virus firstGenerationVirus = new Virus(1.5, 1, "FirstGen", "Flu");
        Virus secondGenerationVirus = new Virus(1.3, 2, "SecondGen", "Cold");
        Virus thirdGenerationVirus = new Virus(1.2, 3, "ThirdGen", "COVID-19");

        firstGenerationVirus.Children.Add(secondGenerationVirus);
        secondGenerationVirus.Children.Add(thirdGenerationVirus);

        Virus clonedFirstGenerationVirus = (Virus)firstGenerationVirus.Clone();

        Console.WriteLine("Cloned Virus:");
        clonedFirstGenerationVirus.DisplayInfo();
        var heroBuilder = new HeroBuilder();
        var enemyBuilder = new EnemyBuilder();

        Console.WriteLine();
        Console.WriteLine("Task5");

        var director = new Director(heroBuilder);
        Hero captainAmerica = heroBuilder
            .SetName("Captain America")
            .SetHeight("Tall")
            .SetBuild("Athletic")
            .SetHairColor("Blonde")
            .SetEyeColor("Blue")
            .SetClothing("Superhero costume")
            .AddToInventory("Shield")
            .Build();

        Hero enemy = enemyBuilder
            .SetName("Red Skull")
            .SetHeight("Average")
            .SetBuild("Medium")
            .SetHairColor("None")
            .SetEyeColor("Red")
            .SetClothing("Nazi uniform")
            .AddToInventory("Tesseract")
            .AddEvilDeeds(new List<string> { "Started World War II", "Attempted to dominate the world" })
            .Build(); 

        Console.WriteLine("Captain America:");
        Console.WriteLine(captainAmerica);

        Console.WriteLine("\nRed Skull:");
        Console.WriteLine(enemy);
    }
}

