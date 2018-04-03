using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW.S._2018.Masarnouski._08
{
    class Program
    {
        static void Main(string[] args)
        {
            ListBookService service = new ListBookService(new ListBookStorage());
            string path = @"D:\EPAM\HW8\NEW.S.2018.Masarnouski.08\NEW.S.2018.Masarnouski.08\BooksListNew.dat";
            Book book1 = new Book("ISBN 954-32-54532-2-423", "CLR via C#", "Jeffrey Richter","",2006,300,200);
            service.AddBook(book1);
            service.ViewBooks();
            service.SaveToStorage(path);
            service.ViewBooks();
            service.LoadFromStorage(path);
            service.ViewBooks();
        }
    }
}
