using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace lab_4_hyrol.Strategy
{
    public class NetworkImage : IImage
    {
        public void LoadImage(string href)
        {
            try
            {
                using (var client = new WebClient())
                {
                    Console.WriteLine($"Loading image '{href}' from network...");
                    byte[] imageData = client.DownloadData(href);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading image '{href}' from network: {ex.Message}");
            }
        }
    }
}
