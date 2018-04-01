using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NEW.S._2018.Masarnouski._08
{
    public class Book
    {
        public string name { get; set; }
        public string author { get; set; }
        public int year { get; set; }
        public int numberOfPages { get; set; }
        public int price { get; set; }

        public Book(string name, string author, int year, int numberOfPages, int price)
        { 
            this.name = name;
            this.author = author;
            this.year = year;
            this.numberOfPages = numberOfPages;
            this.price = price;

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
            Book inputBook = (Book)obj;
            if (this.author == inputBook.author && this.name == inputBook.name
                && this.year == inputBook.year &&
               this.numberOfPages == inputBook.numberOfPages) { return true; }
            else { return false; }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
