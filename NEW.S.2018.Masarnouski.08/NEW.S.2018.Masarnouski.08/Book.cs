using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NEW.S._2018.Masarnouski._08
{
    class Book
    {
        string regExISBN = " ^(?:ISBN(?:-1[03])?:? )?(?=[-0-9 ]{17}$|[-0-9X ]{13}$|[0-9X]{10}$)(?:97[89][- ]?)?[0-9]{1,5}[- ]?(?:[0-9]+[- ]?){2}[0-9X]$";
        public string ISBN {
            get { return ISBN; }
            set
            {
                if (Regex.IsMatch(value, regExISBN)) ISBN = value;
                else return;
            }
        }
        public string Name { get; set; }
        public string Author { get; set; }
        public string PublishingHouse { get; set; }
        public int Year { get; set; }
        public int NumberOfPages { get; set; }
        public int Price { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is null)
                throw new ArgumentNullException(nameof(obj));
            if (!(obj is Book))
                throw new ArgumentException($"Argument {nameof(obj)} must have type Book");
            Book inputBook = (Book)obj;
            if ((this.ISBN == inputBook.ISBN) && (this.Author == inputBook.Author) &&
               (this.PublishingHouse == inputBook.PublishingHouse) && (this.Year == inputBook.Year) &&
               (this.NumberOfPages == inputBook.NumberOfPages)) { return true; }
            else { return false; }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
