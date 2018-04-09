using NEW.S._2018.Masarnouski._08.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW.S._2018.Masarnouski._08.Finders
{
    class Finders
    {
        public class ISBNFind: IFinder<Book>
        {
            public Predicate<Book> Find(object otherISBN)
            {
                if (ReferenceEquals(otherISBN, null))
                {
                    throw new ArgumentNullException(nameof(otherISBN));
                }
          
                Predicate<Book> ISBNFind = delegate (Book book) { return book.Isbn == (string)otherISBN; };
                return ISBNFind;
            }
        }
       
        public class AuthorFind:IFinder<Book>
        {
            public Predicate<Book> Find(object otherAuthor)
            {
                if (ReferenceEquals(otherAuthor, null))
                {
                    throw new ArgumentNullException(nameof(otherAuthor));
                }

                return delegate (Book book) { return book.Author == (string)otherAuthor; };
            }
        }
        public class PriceFind : IFinder<Book>
        {
            public Predicate<Book> Find(object otherAuthor)
            {
                if (ReferenceEquals(otherAuthor, null))
                {
                    throw new ArgumentNullException(nameof(otherAuthor));
                }

                return delegate (Book book) { return book.Price == (int)otherAuthor; };
            }
        }
        public class NameFind : IFinder<Book>
        {
            public Predicate<Book> Find(object otherAuthor)
            {
                if (ReferenceEquals(otherAuthor, null))
                {
                    throw new ArgumentNullException(nameof(otherAuthor));
                }

                return delegate (Book book) { return book.Name == (string)otherAuthor; };
            }
        }

        public class PublisherFind : IFinder<Book>
        {
            public Predicate<Book> Find(object otherAuthor)
            {
                if (ReferenceEquals(otherAuthor, null))
                {
                    throw new ArgumentNullException(nameof(otherAuthor));
                }

                return delegate (Book book) { return book.Publisher == (string)otherAuthor; };
            }
        }

        public class PagesFind : IFinder<Book>
        {
            public Predicate<Book> Find(object otherAuthor)
            {
                if (ReferenceEquals(otherAuthor, null))
                {
                    throw new ArgumentNullException(nameof(otherAuthor));
                }

                return delegate (Book book) { return book.NumberOfPages == (int)otherAuthor; };
            }
        }
        public class YearFind : IFinder<Book>
        {
            public Predicate<Book> Find(object otherAuthor)
            {
                if (ReferenceEquals(otherAuthor, null))
                {
                    throw new ArgumentNullException(nameof(otherAuthor));
                }

                return delegate (Book book) { return book.Year == (int)otherAuthor; };
            }
        }
    }
}
