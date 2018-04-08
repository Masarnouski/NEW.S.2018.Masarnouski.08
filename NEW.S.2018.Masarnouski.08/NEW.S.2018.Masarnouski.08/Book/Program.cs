using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NEW.S._2018.Masarnouski._08.Comparators;
using NEW.S._2018.Masarnouski._08.Interfaces;
using static NEW.S._2018.Masarnouski._08.Finders.Finders;

namespace NEW.S._2018.Masarnouski._08
{
    class Program
    {
        static void Main(string[] args)
        {
            ListBookService service = new ListBookService(new ListBookStorage());
            string path = @"D:\EPAM\HW8\NEW.S.2018.Masarnouski.08\NEW.S.2018.Masarnouski.08\BooksListNew.dat";
            Book book1 = new Book("ISBN 954-32-54532-2-423", "CLR via C#", "Alesya", "", 2006, 300, 200);
            Book book2 = new Book("ISBN 954-32-54532-2-423", "CLR via C#2", "Inna", "", 2006, 300, 500);
            Book book3 = new Book("ISBN 954-32-54532-2-423", "CLR via C#3", "Jenya", "", 2006, 300, 100);
            service.AddBook(book1);
            service.AddBook(book2);
            service.AddBook(book3);
            service.ViewBooks();
            TagPriceSort authorSort = new TagPriceSort();
            service.SortByTag(authorSort);
            service.ViewBooks();
            //AuthorFind finder = new AuthorFind();
            //Book book = service.FindByTag(finder, "Jenya");
            //Console.WriteLine(book.Author + " "+ book.Isbn+" " + book.Name+ " " + book.Price);
            //Console.ReadLine();
        }
}
}
