using System;
using lab_4_hyrol.Chain;
using lab_4_hyrol.Mediator;
using lab_4_hyrol.LightHTML;
using lab_4_hyrol.Strategy;
using lab_4_hyrol.Memento;

class Program
{
    static void Main(string[] args)
    {
        // task1
        SupportHandler levelOneHandler = new LevelOne();
        SupportHandler levelTwoHandler = new LevelTwo();
        SupportHandler levelThreeHandler = new LevelThree();
        SupportHandler levelFourHandler = new LevelFour();

        levelOneHandler.SetNextHandler(levelTwoHandler);
        levelTwoHandler.SetNextHandler(levelThreeHandler);
        levelThreeHandler.SetNextHandler(levelFourHandler);

        Console.WriteLine("Введіть рівень підтримки (1, 2, 3 або 4):");
        int userLevel = Convert.ToInt32(Console.ReadLine());

        levelOneHandler.HandleRequest(userLevel);

        Console.ReadLine();

        // task2
        Console.WriteLine("");
        CommandCentre commandCentre = new CommandCentre();
        Runway runway = new Runway();
        commandCentre.AddRunway(runway);
        Aircraft aircraft = new Aircraft("Boeing 747");
        commandCentre.AddAircraft(aircraft);
        commandCentre.LandAircraft(aircraft);
        commandCentre.TakeOffAircraft(aircraft);

        //task3
        Console.WriteLine("");
        var div = new LightElementNode("div", DisplayType.Block, ClosingType.ClosingTag);
        var textNode = new LightTextNode("Hello, World!");
        div.AddChild(textNode);
        div.AddEventListener("click", new ClickEventListener());
        div.AddEventListener("mouseover", new MouseOver());
        div.TriggerEvent("click");
        div.TriggerEvent("mouseover");

        //task4
        Console.WriteLine("");
        var filesystemStrategy = new lab_4_hyrol.Strategy.FilesystemImage();
        var networkStrategy = new lab_4_hyrol.Strategy.NetworkImage();
        var imageFromFilesystem = new lab_4_hyrol.Strategy.Image(filesystemStrategy);
        var imageFromNetwork = new lab_4_hyrol.Strategy.Image(networkStrategy);
        imageFromFilesystem.Load("Image.jpg");
        imageFromNetwork.Load("https://upload.wikimedia.org/wikipedia/commons/7/78/Image.jpg");

        //task5
        Console.WriteLine("");
        var initialDocument = new TextDocument("Hello, World!");

        var editor = new TextEditor(initialDocument);

        Console.WriteLine("Initial Document:");
        editor.DisplayDocument();
        Console.WriteLine();

        editor.Type(" This is additional text.");
        editor.DisplayDocument();
        editor.Save();

        editor.Type(" Adding more text.");
        editor.DisplayDocument();
        editor.Undo();
        editor.DisplayDocument();
    }
}


