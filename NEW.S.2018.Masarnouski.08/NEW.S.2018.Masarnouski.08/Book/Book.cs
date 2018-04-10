using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NEW.S._2018.Masarnouski._08
{
    public class Book:IComparable, IComparable<Book>, IEquatable<Book>
    {
        const string reg = "^(?:ISBN(?:-1[03])?:? )?(?=[-0-9 ]{17}$|[-0-9X ]{13}$|[0-9X]" +
    "{10}$)(?:97[89][- ]?)?[0-9]{1,5}[- ]?(?:[0-9]+[- ]?){2}[0-9X]$";

        #region fields
        string isbn;
        string name;
        string author;
        string publisher;
        int year;
        int numberOfPages;
        decimal price;
        #endregion

        #region Properties
        /// <summary>
        /// The international standard number
        /// </summary>
        public string Isbn
        { 
            get { return isbn; }
            set
            {
                Regex regex = new Regex(reg);
                if (regex.IsMatch(value))
                    isbn = value;
                else
                    throw new ArgumentException($"{nameof(value)} have wrong format");
            }
        }

        /// <summary>
        /// The title of the book
        /// </summary>
        public string Name
        {
            get { return this.name; }

            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException($"{nameof(value)}");
                }

                if (value == string.Empty)
                {
                    throw new ArgumentException($"{nameof(value)} must be not empty");
                }

                this.name = value;
            }
        }

        /// <summary>
        ///  The author of book
        /// </summary>
        public string Author
        {
            get { return this.author; }

            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException($"{nameof(value)}");
                }

                if (value == string.Empty)
                {
                    throw new ArgumentException($"{nameof(value)} must be not empty");
                }

                this.author = value;
            }
        }

        /// <summary>
        /// The publisher of book
        /// </summary>
        public string Publisher
        {
            get { return this.publisher; }

            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException($"{nameof(value)}");
                }

                if (value == string.Empty)
                {
                    throw new ArgumentException($"{nameof(value)} must be not empty");
                }

                this.publisher = value;
            }
        }

        /// <summary>
        /// The year of publishing 
        /// </summary>
        public int Year {
            get { return this.year; }
            set
            {
                if (value < 0)

                    throw new ArgumentException($"{nameof(value)} must be greater then 0");
                if (value.ToString().Length > 4)
                {
                    throw new ArgumentException($"{nameof(value)} in not correct"); }
                else
                    year = value;
            }
        }

        /// <summary>
        /// Amount of pages
        /// </summary>
        public int NumberOfPages
            {
            get { return numberOfPages; }
            set
            {
                if (value < 0)
                    throw new ArgumentException($"{nameof(value)} must be greater then 0");
                else
                numberOfPages = value;
            }
        }

        /// <summary>
        ///  The price of book 
        /// </summary>
        public decimal Price
        {
            get { return price; }
            set {
                if (value < 0)
                    throw new ArgumentException($"{nameof(value)} must be greater then 0");
                else
                price = value;
            }
        }

        #endregion
        /// <summary>
        /// Initialize a new Book
        /// </summary>
        /// <param name="isbn"> The international standard number </param>
        /// <param name="name"> The title of book </param>
        /// <param name="author"> The author of book </param>
        /// <param name="publisher"> The publisher of book </param>
        /// <param name="year"> The year of publishing </param>
        /// <param name="numberOfPages"> Amount of pages </param>
        /// <param name="price"> The price of book </param>
        public Book(string isbn, string name, string author, string publisher, int year, int numberOfPages, int price)
        {
            this.Isbn = isbn;
            this.Name = name;
            this.Author = author;
            this.Publisher = publisher;
            this.Year = year;
            this.NumberOfPages = numberOfPages;
            this.Price = price;

        }
        /// <summary>
        /// Compares current book with <paramref name="other"/> book>
        /// </summary>
        /// <param name="other"> The book to compare with </param>
        /// <returns> True if books are aqual, otherwise, false </returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(obj, null))
                return false;

            if (this.GetType() != obj.GetType())
                throw new ArgumentException($"{nameof(obj)} must have wrong type");

            return Equals((Book)obj);
        }
        /// <summary>
        /// Coverts book to a hashcode
        /// </summary>
        /// <returns> Numeric representation of current book </returns>
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        /// <summary>
        /// Compares current book with <paramref name="other"/> book>
        /// </summary>
        /// <param name="other"> The book to compare with </param>
        /// <returns> True if books are aqual, otherwise, false </returns>
        public bool Equals(Book other)
        {
            if (ReferenceEquals(other, null))
                return false;

            return this.Isbn == other.Isbn && this.Author == other.Author && this.Name == other.Name
                && this.Year == other.Year && this.Publisher == other.Publisher &&
               this.NumberOfPages == other.NumberOfPages && this.Price == other.Price;
        }

        /// <summary>
        /// Conpares <paramref name="firstBook"/> and <paramref name="secondBook"/>.
        /// </summary>
        /// <param name="firstBook">A first book.</param>
        /// <param name="secondBook">A second book.</param>
        /// <returns> True if books are equal, otherwise, false </returns>
        public static bool operator ==(Book firstBook, Book secondBook)
        {
            return firstBook.Equals(secondBook);
        }

        /// <summary>
        /// Conpares <paramref name="firstBook"/> and <paramref name="secondBook"/>.
        /// </summary>
        /// <param name="firstBook">A first book.</param>
        /// <param name="secondBook">A second book.</param>
        /// <returns> False if books are equal, otherwise, true </returns>
        public static bool operator !=(Book firstBook, Book secondBook)
        {
            return !firstBook.Equals(secondBook);
        }

        /// <summary>
        /// Compares books by price
        /// </summary>
        /// <param name="other">Book to compare with</param>
        /// <returns> If the current instance book greater <paramref name="other"/>: 1, if equal : 0 , if less : -1 </returns>
        public int CompareTo(Book other)
        {
            if (ReferenceEquals(other, null))
                return 1;

            return this.Price.CompareTo(other.Price);
        }
        /// <summary>
        /// Converts book to string representation.
        /// </summary>
        public override string ToString()
        {
           return $" ISBN  - {Isbn} \n Name - {Name} \n Author - {Author} \n Publisher - {Publisher} \n Year - {Year} \n" +
                $" Price - {Price} \n Pages - {NumberOfPages}";
        }

        /// <summary>
        /// Compares books by price
        /// </summary>
        /// <param name="obj">Book to compare with</param>
        /// <returns> If the current instance book greater <paramref name="obj"/>: 1, if equal : 0 , if less : -1 </returns>
        public int CompareTo(object obj)
        {
            if (ReferenceEquals(obj, null))
            {
                return 1;
            }

            if (this.GetType() != obj.GetType())
            {
                throw new ArgumentException("Arqument is not a book", nameof(obj));
            }

            return this.CompareTo((Book)obj);
        }
    }
}
