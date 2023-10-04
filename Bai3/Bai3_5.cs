using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenAcademy
{
    internal class Bai3_5
    {
        public void BookDetails()
        {
            Book book0 = new Book();
            book0.author = "Emily Bronte";
            book0.totalPages = 400;
            book0.isbn = "WH400";
            book0.title = "Wuthering Heights";
            book0.currentPage = 1;


            System.Console.WriteLine("BOOK 0:");
            System.Console.WriteLine("Author: " + book0.author);
            System.Console.WriteLine("Total Pages: " + book0.totalPages);
            System.Console.WriteLine("Book Number: " + book0.isbn);
            System.Console.WriteLine("Title: " + book0.title);
            System.Console.WriteLine("Current Page: " + book0.currentPage);

            System.Console.WriteLine("\n");
            book0.flipPageBackward();

            System.Console.WriteLine("\n");
            book0.flipPageForward();

            System.Console.WriteLine("\n");





            Book book1 = new Book();
            book1.BookInput();






        }
    }
}
