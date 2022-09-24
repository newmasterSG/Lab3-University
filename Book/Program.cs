﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Can you write your book title? ");
            string title = Console.ReadLine();
            Console.Write("Also author : ");
            string author = Console.ReadLine();
            Console.WriteLine("The last that we need to it's content : ");
            string content = Console.ReadLine();
            Book book = new Book(new Title(title), new Author(author), new Content(content));
            Console.WriteLine();
            Console.WriteLine("Okey, the process completed.");
            Console.Clear();
            Console.WriteLine($"The book title is {book.Title.TitleName} ");
            Console.WriteLine($"The author of this book is {book.Author.Writer}");
            Console.WriteLine("The book context : ");
            Console.WriteLine($"{book.Content.Сontents}");
        }
    }
}
