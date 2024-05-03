using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3_hyrol.Proxy
{
    public class SmartTextChecker : ITextReader
    {
        private SmartTextReader reader;

        public SmartTextChecker()
        {
            reader = new SmartTextReader();
        }

        public string[,] ReadText(string filePath)
        {
            Console.WriteLine($"Opening file: {filePath}");

            string[,] textArray = reader.ReadText(filePath);

            Console.WriteLine($"Successfully read file: {filePath}");
            Console.WriteLine($"Number of lines: {textArray.GetLength(0)}");
            Console.WriteLine($"Number of characters: {textArray.Length}");

            return textArray;
        }
    }
}
