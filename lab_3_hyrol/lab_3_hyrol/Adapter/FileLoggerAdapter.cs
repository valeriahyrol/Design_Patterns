using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3_hyrol
{
    class FileLoggerAdapter : ILogger
    {
        private FileWriter fileWriter;

        public FileLoggerAdapter(FileWriter fileWriter)
        {
            this.fileWriter = fileWriter;
        }

        public void Log(string message)
        {
            fileWriter.WriteLine($"[Log] {message}");
        }

        public void Error(string message)
        {
            fileWriter.WriteLine($"[Error] {message}");
        }

        public void Warn(string message)
        {
            fileWriter.WriteLine($"[Warning] {message}");
        }
    }
}
