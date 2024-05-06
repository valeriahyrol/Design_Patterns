using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4_hyrol.Memento
{
    public class TextEditor
    {
        private TextDocument _document;
        private TextDocument _backup;

        public TextEditor(TextDocument document)
        {
            _document = document;
            _backup = new TextDocument(document.Content);
        }

        public void Save()
        {
            Console.WriteLine("Saving current state of the document...");
            _backup = new TextDocument(_document.Content);
        }

        public void Undo()
        {
            Console.WriteLine("Undoing changes...");
            _document.Content = _backup.Content;
        }

        public void Type(string text)
        {
            Console.WriteLine($"Typing: {text}");
            _document.Content += text;
        }

        public void DisplayDocument()
        {
            _document.Display();
        }
    }
}
