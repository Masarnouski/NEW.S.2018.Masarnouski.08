using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW.S._2018.Masarnouski._08.Books.Logic
{
   public class CustomBookFormat : IFormatProvider, ICustomFormatter
    {
        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            if (arg is Book && format == "Custom")
            {
                var book = (Book)arg;
                return $"CustomBookFormat Representation {book.Isbn}, {book.Author} - {book.Name}, {book.Publisher}, {book.Year}," +
                   $" {book.NumberOfPages} pages, {book.Price.ToString("C")}";
            }
            else
            {
                try
                {
                   return HandleOtherFormats(format, arg);
                }
                catch (FormatException e)
                {
                    throw new FormatException(String.Format($"The format of '{nameof(format)}' is invalid."), e);
                }
            }
        }

        private string HandleOtherFormats(string format, object arg)
        {
            if (arg is IFormattable)
                return ((IFormattable)arg).ToString(format, CultureInfo.CurrentCulture);
            else if (arg != null)
                return arg.ToString();
            else
                return String.Empty;
        }


        public object GetFormat(Type formatType)
        {
            if (formatType == typeof(ICustomFormatter))
            {
                return this;
            }

            return null;
        }
    }
}
