using System;
using System.Collections.Generic;
using System.Text;

namespace Book
{
    internal class Author
    {
        private readonly string _writer;

        public Author(string writer)
        {
            this._writer = writer;
        }


        public string Writer
        {
            get { return _writer; }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(_writer);
        }
    }
}
