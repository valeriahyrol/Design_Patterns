using lab_3_hyrol;
using lab_3_hyrol.Bridge;
using lab_3_hyrol.Compon;
using lab_3_hyrol.Decorator;
using lab_3_hyrol.EasyWeight;
using lab_3_hyrol.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        //task1
        FileWriter fileWriter = new FileWriter();
        ILogger fileLogger = new FileLoggerAdapter(fileWriter);

        fileLogger.Log("This is a log message");
        fileLogger.Error("This is an error message");
        fileLogger.Warn("This is a warning message");

        //task2
        Hero warrior = new Warrior("Warrior", 100);
        Hero mage = new Mage("Mage", 80);
        Hero paladin = new Paladin("Paladin", 110);

        Console.WriteLine();
        Console.WriteLine($"Strength of {warrior.Name}: {warrior.GetPower()}");
        Console.WriteLine($"Strength of {mage.Name}: {mage.GetPower()}");
        Console.WriteLine($"Strength of {paladin.Name}: {paladin.GetPower()}");

        //task3
        Renderer vectorRenderer = new VectorRenderer();
        Shape circle = new Circle(vectorRenderer);
        Shape square = new Square(vectorRenderer);
        Shape triangle = new Triangle(vectorRenderer);
        
        Console.WriteLine();
        circle.Draw();
        square.Draw();
        triangle.Draw();

        Console.WriteLine();

       
        Renderer rasterRenderer = new RasterRenderer();
        circle = new Circle(rasterRenderer);
        square = new Square(rasterRenderer);
        triangle = new Triangle(rasterRenderer);

        circle.Draw();
        square.Draw();
        triangle.Draw();

        Console.WriteLine();
        //task4
        ITextReader textReader = new SmartTextChecker();
        string[,] textArray = textReader.ReadText("words.txt");

        Regex allowedFilesRegex = new Regex(@"\w+.txt$"); 
        textReader = new SmartTextReaderLocker(allowedFilesRegex);
        textArray = textReader.ReadText("words.txt");

        Console.WriteLine();
        //task5
        var page = new LightElementNode("html", DisplayType.Block, ClosingType.ClosingTag);
        var head = new LightElementNode("head", DisplayType.Block, ClosingType.ClosingTag);
        var title = new LightElementNode("title", DisplayType.Block, ClosingType.ClosingTag);
        title.AddChild(new LightTextNode("Sample Page"));
        head.AddChild(title);
        page.AddChild(head);

        var body = new LightElementNode("body", DisplayType.Block, ClosingType.ClosingTag);
        var header = new LightElementNode("header", DisplayType.Block, ClosingType.ClosingTag);
        header.AddChild(new LightTextNode("Welcome to our website!"));
        body.AddChild(header);

        var main = new LightElementNode("main", DisplayType.Block, ClosingType.ClosingTag);
        var paragraph = new LightElementNode("p", DisplayType.Block, ClosingType.ClosingTag);
        paragraph.AddChild(new LightTextNode("This is a sample paragraph."));
        main.AddChild(paragraph);

        var list = new LightElementNode("ul", DisplayType.Block, ClosingType.ClosingTag);
        var listItem1 = new LightElementNode("li", DisplayType.Block, ClosingType.ClosingTag);
        listItem1.AddChild(new LightTextNode("Item 1"));
        var listItem2 = new LightElementNode("li", DisplayType.Block, ClosingType.ClosingTag);
        listItem2.AddChild(new LightTextNode("Item 2"));
        list.AddChild(listItem1);
        list.AddChild(listItem2);
        main.AddChild(list);
        body.AddChild(main);
        page.AddChild(body);
        page.Display();

        Console.WriteLine();
        //task6
        HTMLPage htmlPage = new HTMLPage();
        string[] lines = System.IO.File.ReadAllLines(@"book.txt");

        foreach (string line in lines)
        {
            if (string.IsNullOrWhiteSpace(line))
                continue;

            if (line.Length < 20)
            {
                htmlPage.AddNode(new LightHeaderNode(line, 2));
            }
            else if (char.IsWhiteSpace(line[0]))
            {
                htmlPage.AddNode(new LightBlockquoteNode(line));
            }
            else
            {
                htmlPage.AddNode(new LightTextNode1(line));
            }
        }

        htmlPage.DisplayPage();
    }
}
