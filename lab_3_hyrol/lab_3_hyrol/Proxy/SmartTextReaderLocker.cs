using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lab_3_hyrol.Proxy
{    
    public class SmartTextReaderLocker : ITextReader
    {
        private SmartTextReader reader;
        private Regex allowedFilesRegex;

        public SmartTextReaderLocker(Regex allowedFilesRegex)
        {
            reader = new SmartTextReader();
            this.allowedFilesRegex = allowedFilesRegex;
        }

        public string[,] ReadText(string filePath)
        {
            if (allowedFilesRegex.IsMatch(filePath))
            {
                return reader.ReadText(filePath);
            }
            else
            {
                Console.WriteLine("Access denied!");
                return null;
            }
        }
    }

}
