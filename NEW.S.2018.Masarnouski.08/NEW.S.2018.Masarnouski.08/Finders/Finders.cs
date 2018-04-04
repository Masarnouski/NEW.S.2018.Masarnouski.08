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
        public class FindISBN: IFinder<Book>
        {
            public Predicate<Book> Find(string otherISBN)
            {
                if (ReferenceEquals(otherISBN, null))
                {
                    throw new ArgumentNullException(nameof(otherISBN));
                }
          
                Predicate<Book> ISBNFind = delegate (Book book) { return book.Isbn == otherISBN; };
                return ISBNFind;
            }
        }
       
        public class AuthorFind:IFinder<Book>
        {
            public Predicate<Book> Find(string otherAuthor)
            {
                if (ReferenceEquals(otherAuthor, null))
                {
                    throw new ArgumentNullException(nameof(otherAuthor));
                }

                return delegate (Book book) { return book.Author == otherAuthor; };
            }
        }
    }
}
