using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4_hyrol.Memento
{
    public class TextDocument
    {
        public string Content { get; set; }

        public TextDocument(string content)
        {
            Content = content;
        }

        public void Display()
        {
            Console.WriteLine("Document Content:");
            Console.WriteLine(Content);
        }
    }
}
