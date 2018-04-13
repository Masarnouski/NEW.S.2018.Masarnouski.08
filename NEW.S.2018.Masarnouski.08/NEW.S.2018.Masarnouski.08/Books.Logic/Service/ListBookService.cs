using NEW.S._2018.Masarnouski._08.Books.Logic.Finders;
using NEW.S._2018.Masarnouski._08.Books.Logic.Storage;
using System;
using System.Collections.Generic;
using NLog;

namespace NEW.S._2018.Masarnouski._08.Books.Logic.Service
{
   public class ListBookService
    {
        private List<Book> bookList = new List<Book>();
        private static Logger logger = LogManager.GetCurrentClassLogger();
        IBookListStorage storage;
        /// <summary>
        /// Initialize service with storage
        /// </summary>
        /// <param name="storage"> Storage </param>
        public ListBookService(IBookListStorage storage)
        {
            this.storage = storage;
            logger.Info($"Service with storage {storage} has successfully created");
        }
        /// <summary>
        /// Show the list of books
        /// </summary>
        public void ViewBooks()
        {
            foreach (var item in bookList)
            {
                Console.WriteLine($"{item.Isbn} {item.Name} {item.Author} {item.Publisher} {item.Price}");
            }
            Console.ReadLine();
        }
        /// <summary>
        /// Add book to collection of books,if not exists
        /// </summary>
        /// <param name="book"> Book </param>
        public void  AddBook(Book book)
        {
            if (ReferenceEquals(book, null))
            {
                throw new ArgumentNullException(nameof(book));
            }
            if (bookList.Contains(book))
                throw new Exception("This book is alrady exists");
            else
            {
                bookList.Add(book);
                logger.Info($"Book {book.Name} succesfully added");
            }
        }
        /// <summary>
        /// Remove Book from collection, if exists
        /// </summary>
        /// <param name="book"> Book </param>
        public void RemoveBook(Book book)
        {
            if (ReferenceEquals(book, null))
            {
                throw new ArgumentNullException(nameof(book));
            }
            if (bookList.Contains(book))
            {
                bookList.Remove(book);
                logger.Info($"Book {book.Name} succesfully removed");
            }
            else
                throw new Exception("This book is alrady exists");
        }
        /// <summary>
        /// Loads collection of books from storage
        /// </summary>
        public void LoadFromStorage()
        {
            bookList.Clear();
            bookList = storage.Load();
            logger.Info($"Collection of books have loaded to file");
        }
        /// <summary>
        /// Save collection of books to storage
        /// </summary>
        public void SaveToStorage()
        {
            storage.Save(bookList);
            logger.Info($"Collection of books have saveed to file");
        }
        /// <summary>
        /// Sorts collection of book by defined tag
        /// </summary>
        /// <param name="comparer"> comparer, incapsulates comparison logic by tag </param>
        public void SortByTag(IComparer<Book> comparer)
        {
            if (ReferenceEquals(comparer, null))
            {
                throw new ArgumentNullException(nameof(comparer));
            }
            bookList.Sort(comparer);
            logger.Info($"Collection of books have saveed");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="finder"> finder, incapsulate find logic by tag </param>
        /// <param name="tag"> name of tag </param>
        /// <returns> fiended book </returns>
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
