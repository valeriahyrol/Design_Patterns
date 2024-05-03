using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3_hyrol
{
    class FileWriter
    {
        public void Write(string message)
        {
            // Реалізація запису у файл
            Console.WriteLine($"Writing to file: {message}");
        }

        public void WriteLine(string message)
        {
            // Реалізація запису у файл з переходом на новий рядок
            Console.WriteLine($"Writing to file: {message}");
        }
    }

}
