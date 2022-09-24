using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Book
{
    internal class Title
    {
        private readonly string _title;

        public string TitleName
        {
            get { return _title; }
        }
        public Title(string title)
        {
            this._title = title;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(_title);
        }
    }
}
