using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW.S._2018.Masarnouski._08.Comparators
{
    public class TagISBNSort : IComparer<Book>
    {
        public int Compare(Book first, Book second)
        {
            if (ReferenceEquals(first,null))
            {
                throw new ArgumentNullException(nameof(first));
            }

            if (ReferenceEquals(second, null))
            {
                throw new ArgumentNullException(nameof(second));
            }

            return string.Compare(first.Isbn, second.Isbn);
        }
    }

    public class TagAuthorSort : IComparer<Book>
    {
        public int Compare(Book first, Book second)
        {
            if (ReferenceEquals(first, null))
            {
                throw new ArgumentNullException(nameof(first));
            }

            if (ReferenceEquals(second, null))
            {
                throw new ArgumentNullException(nameof(second));
            }

            return string.Compare(first.Author, second.Author, StringComparison.InvariantCultureIgnoreCase);
        }
    }

    public class TagNameSort : IComparer<Book>
    {
        public int Compare(Book first, Book second)
        {
            if (ReferenceEquals(first, null))
            {
                throw new ArgumentNullException(nameof(first));
            }

            if (ReferenceEquals(second, null))
            {
                throw new ArgumentNullException(nameof(second));
            }

            return string.Compare(first.Name, second.Name, StringComparison.InvariantCultureIgnoreCase);
        }
    }

    public class TagPublisherSort : IComparer<Book>
    {
        public int Compare(Book first, Book second)
        {
            if (ReferenceEquals(first, null))
            {
                throw new ArgumentNullException(nameof(first));
            }

            if (ReferenceEquals(second, null))
            {
                throw new ArgumentNullException(nameof(second));
            }

            return string.Compare(first.Publisher, second.Publisher, StringComparison.InvariantCultureIgnoreCase);
        }
    }

    public class TagPriceSort : IComparer<Book>
    {
        public int Compare(Book first, Book second)
        {
            if (ReferenceEquals(first, null))
            {
                throw new ArgumentNullException(nameof(first));
            }

            if (ReferenceEquals(second, null))
            {
                throw new ArgumentNullException(nameof(second));
            }

            return Decimal.Compare(first.Price, second.Price);
        }
    }

    public class TagNumberOfPagesSort : IComparer<Book>
    {
        public int Compare(Book first, Book second)
        {
            if (ReferenceEquals(first, null))
            {
                throw new ArgumentNullException(nameof(first));
            }

            if (ReferenceEquals(second, null))
            {
                throw new ArgumentNullException(nameof(second));
            }

            return first.NumberOfPages.CompareTo(second.NumberOfPages);
        }
    }

    public class TagYearSort : IComparer<Book>
    {
        public int Compare(Book first, Book second)
        {
            if (ReferenceEquals(first, null))
            {
                throw new ArgumentNullException(nameof(first));
            }

            if (ReferenceEquals(second, null))
            {
                throw new ArgumentNullException(nameof(second));
            }


            return first.Year.CompareTo(second.Year);
        }
    }
}
