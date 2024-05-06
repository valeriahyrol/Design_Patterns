using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4_hyrol.Strategy
{
    public class FilesystemImage : IImage
    {
        public void LoadImage(string href)
        {
            try
            {
                string filePath = Path.Combine(Environment.CurrentDirectory, href);
                if (File.Exists(filePath))
                {
                    Console.WriteLine($"Loading image '{href}' from filesystem...");
                }
                else
                {
                    Console.WriteLine($"File '{href}' does not exist in the filesystem.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading image '{href}' from filesystem: {ex.Message}");
            }
        }
    }
}
