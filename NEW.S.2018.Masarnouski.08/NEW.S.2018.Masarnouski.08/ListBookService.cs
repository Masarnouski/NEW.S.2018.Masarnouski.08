using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW.S._2018.Masarnouski._08
{
   public class ListBookService
    {
        ListBookStorage storage;
        public ListBookService(ListBookStorage storage)
        {
            this.storage = storage;
        }
        public void  AddBook(Book book)
        {
            if (storage.bookList.Contains(book))
                throw new Exception("This book is alrady exists");
            else
                storage.bookList.Add(book);
        }
        public void RemoveBook(Book book)
        {
            if (storage.bookList.Contains(book))
                storage.bookList.Remove(book);
            else
                throw new Exception("This book is alrady exists");
        }
    }
}
