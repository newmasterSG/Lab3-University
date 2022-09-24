using System;
using System.Collections.Generic;
using System.Text;

namespace Book
{
    internal class Content
    {
        private string _context;
        public string Сontents
        {
            get { return _context; }
        }

        public Content(string context)
        {
            this._context = context;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(_context);
        }
    }
}
