using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NEW.S._2018.Masarnouski._08.Interfaces;

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
        public void LoadFromStorage()
        {
            bookList.Clear();
            bookList = storage.Load();
        }

        public void SaveToStorage()
        {
            storage.Save(bookList);
        }

        public void SortByTag(IComparer<Book> comparer)
        {
            if (ReferenceEquals(comparer, null))
            {
                throw new ArgumentNullException(nameof(comparer));
            }
            bookList.Sort(comparer);
        }

        public Book FindByTag(IFinder<Book> finder,object tag)
        {
            if (ReferenceEquals(finder, null))
            {
                throw new ArgumentNullException(nameof(finder));
            }
           return bookList.Find(finder.Find(tag));
        }

    }
}
