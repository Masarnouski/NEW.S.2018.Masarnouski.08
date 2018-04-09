using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NEW.S._2018.Masarnouski._08
{
    public class Book: IComparable<Book>, IEquatable<Book>
    {
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
        public string Isbn
        { 

            get { return isbn; }
            set {
                string reg = "^(?:ISBN(?:-1[03])?:? )?(?=[-0-9 ]{17}$|[-0-9X ]{13}$|[0-9X]" +
     "{10}$)(?:97[89][- ]?)?[0-9]{1,5}[- ]?(?:[0-9]+[- ]?){2}[0-9X]$";
                Regex regex = new Regex(reg);
                if (regex.IsMatch(value))
                    isbn = value;
                else
                    throw new ArgumentException($"{nameof(value)} have wrong format");
            } }
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
        /// Compares books
        /// </summary>
        /// <param name="obj"> the book to compare with</param>
        /// <returns> true if the "obj" is equal to the current object instance; otherwise, false.</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, null) && !(ReferenceEquals(obj, null)))
                return false;

            if(ReferenceEquals(obj, null) && !(ReferenceEquals(this, null)))
                return false;

            if (ReferenceEquals(this, obj))
                return true;

            if (!(obj is Book))
                throw new ArgumentException($"Argument {nameof(obj)} must have type Book");

            return Equals((Book)obj);
        }
        /// <summary>
        /// coverts book to a HashCode
        /// </summary>
        /// <returns> numeric representation of an object </returns>
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        /// <summary>
        /// Compares books
        /// </summary>
        /// <param name="other"> the book to compare with</param>
        /// <returns> true if the "oter" is equal to the current object instance; otherwise, false.</returns>
        public bool Equals(Book other)
        {
            if (ReferenceEquals(this, null) && !(ReferenceEquals(other, null)))
                return false;

            if (ReferenceEquals(other, null) && !(ReferenceEquals(this, null)))
                return false;

            if (ReferenceEquals(this, other))
                return true;

            return this.Isbn == other.Isbn && this.Author == other.Author && this.Name == other.Name
                && this.Year == other.Year && this.Publisher == other.Publisher &&
               this.NumberOfPages == other.NumberOfPages && this.Price == other.Price;
        }
        /// <summary>
        /// Compares books by price
        /// </summary>
        /// <param name="other">book to compare with</param>
        /// <returns> if this current instance book > other: 1, if equal : 0 , if less : -1 </returns>
        public int CompareTo(Book other)
        {
            if (ReferenceEquals(other, null))
                throw new ArgumentNullException(nameof(other));

            if (this.Price > other.Price)
                return 1;
            if (this.Price < other.Price)
                return -1;
            else
                return 0;
        }
        /// <summary>
        /// Converts book to string representation.
        /// </summary>
        public override string ToString()
        {
           return $" ISBN  - {Isbn} \n Name - {Name} \n Author - {Author} \n Publisher - {Publisher} \n Year - {Year} \n" +
                $" Price - {Price} \n Pages - {NumberOfPages}";
        }

    }
}
