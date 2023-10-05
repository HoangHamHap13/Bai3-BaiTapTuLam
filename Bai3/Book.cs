using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenAcademy
{
    internal class Book
    {
        public string author;
        public int totalPages;
        public string isbn;
        public string title;
        public int currentPage; 

        //Tạo constructor (hàm tạo) mặc định và thiết lập currentPage = 1;
        public Book()
        {
            currentPage = 1;
        }

        //Tạo constructor với tất cả các tham số để khởi tạo các trường tương ứng
        public Book(string author, int totalPages, string isbn, string title, int currentPage)
        {
            System.Console.WriteLine("Author: "); author = Console.ReadLine();
            System.Console.WriteLine("Total Pages: "); totalPages = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Book Number: "); isbn = Console.ReadLine();
            System.Console.WriteLine("Title: "); title = Console.ReadLine();
            System.Console.WriteLine("Current Page"); currentPage = Convert.ToInt32(Console.ReadLine());
        }

        //Tạo phương thức lật sang trang trước
        public void flipPageBackward()
        {
            int recentPage;
            Console.WriteLine("Recent Page: "); recentPage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Previous Page: {0}", recentPage-1); 

        }


        //Tạo phương thức lật sang trang sau
        public void flipPageForward()
        {
            int recentPage;
            int flickPage;
            Console.WriteLine("Recent page: "); recentPage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many pages do you want to flick through?"); flickPage = Convert.ToInt32(Console.ReadLine());
            int currentPage = recentPage + flickPage;
            if (currentPage > totalPages) Console.WriteLine("Not available");
            else Console.WriteLine("Current page: {0}", currentPage);
        }










    }
}
