using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NEW.S._2018.Masarnouski._08
{
    public class Book: IComparable, IEquatable<Book>
    {
        public string Isbn { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int Year { get; set; }
        public int NumberOfPages { get; set; }
        public int Price { get; set; }

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

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

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
               this.NumberOfPages == other.NumberOfPages;
        }
    }
}
