using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NEW.S._2018.Masarnouski._08.Books.Logic.Comparators;
using NEW.S._2018.Masarnouski._08.Books.Logic.Service;
using NEW.S._2018.Masarnouski._08.Books.Logic.Storage;
using static NEW.S._2018.Masarnouski._08.Books.Logic.Finders.Finders;

namespace NEW.S._2018.Masarnouski._08.Books.Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\EPAM\HW8\NEW.S.2018.Masarnouski.08\NEW.S.2018.Masarnouski.08\BooksListNew.dat";
            ListBookService service = new ListBookService(new ListBookStorage(path));
            Book book1 = new Book("ISBN 978-2-93286-181-3", "CLR via C#", "Alesya", "Eversev",2005, 20, 200);
            Book book2 = new Book("ISBN 978-5-93286-181-3", "CLR via C#2", "Inna", "Eversev", 2006, 200, 200);
            Book book3 = new Book("ISBN 978-4-93286-181-3", "CLR via C#3", "Jenya", "Eversev", 2006, 100, 100);

            service.AddBook(book1);
            service.AddBook(book2);
            service.AddBook(book3);


            Console.WriteLine(String.Format(new CustomBookFormat(), "My representation : {0}", 55));
            Console.ReadLine();
            //TagPriceSort authorSort = new TagPriceSort();
            //service.SortByTag(authorSort);


            //PriceFind finder = new PriceFind();
            //Book book = service.FindByTag(finder, 200);

            //service.SaveToStorage();
            //service.LoadFromStorage();

            
        }
}
}
