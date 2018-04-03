using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW.S._2018.Masarnouski._08
{
   public class ListBookService
    {
        private List<Book> bookList = new List<Book>();
        IBookListStorage storage;

        public ListBookService(IBookListStorage storage)
        {
            this.storage = storage;
        }

        public void ViewBooks()
        {
            foreach (var item in bookList)
            {
                Console.WriteLine($"{item.Isbn} {item.Name} {item.Author} {item.Publisher} {item.Price}");
            }
            Console.ReadLine();
        }
        public void  AddBook(Book book)
        {
            if (ReferenceEquals(book, null))
            {
                throw new ArgumentNullException(nameof(book));
            }
            if (bookList.Contains(book))
                throw new Exception("This book is alrady exists");
            else
                bookList.Add(book);
        }
        public void RemoveBook(Book book)
        {
            if (ReferenceEquals(book, null))
            {
                throw new ArgumentNullException(nameof(book));
            }
            if (bookList.Contains(book))
                bookList.Remove(book);
            else
                throw new Exception("This book is alrady exists");
        }
        public void LoadFromStorage(string path)
        {
            bookList.Clear();
            bookList = storage.Load(path);
        }
        public void SaveToStorage(string path)
        {
            storage.Save(path, bookList);
        }
    }
}
