using System;
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
            Console.WriteLine("The last that we need it's content : ");
            string content = Console.ReadLine();
            Book book = new Book(new Title(title), new Author(author), new Content(content));
            Console.WriteLine();
            Console.WriteLine("Okey, the process completed.");
            Console.Clear();
            book.Title.Show();
            book.Author.Show();
            book.Content.Show();
            Console.WriteLine();
        }

        
    }
}
