using System;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NEW.S._2018.Masarnouski._08.Books.Logic;
using NUnit.Framework;

namespace Books.Logic.Tests
{
    [TestFixture]
    public class BookTests
    {
        [TestMethod]
        [TestCase ("IANPYNP", null, ExpectedResult = "ISBN 978-2-93286-181-3, Alesya - CLR via C#, Eversev, 2005, 20 pages, 200,00р.")]
        [TestCase("IANPYN", null, ExpectedResult = "ISBN 978-2-93286-181-3, Alesya - CLR via C#, Eversev, 2005, 20 pages")]
        [TestCase("IANPY", null, ExpectedResult = "ISBN 978-2-93286-181-3, Alesya - CLR via C#, Eversev, 2005")]
        [TestCase("IANP", null, ExpectedResult = "ISBN 978-2-93286-181-3, Alesya - CLR via C#, Eversev")]
        [TestCase("IAN", null, ExpectedResult = "ISBN 978-2-93286-181-3, Alesya - CLR via C#")]
        [TestCase("IA", null, ExpectedResult = "ISBN 978-2-93286-181-3, Alesya")]
        public string ToString_ProviderNull_FormatTest(string format, IFormatProvider formatProvider)
        {
            Book book1 = new Book("ISBN 978-2-93286-181-3", "CLR via C#", "Alesya", "Eversev", 2005, 20, 200);
            string s =  book1.ToString(format,formatProvider);
            return s;
        }
        [TestMethod]
        [TestCase("IANPYNP", null, ExpectedResult = "ISBN 978-2-93286-181-3, Alesya - CLR via C#, Eversev, 2005, 20 pages, $200.00")]
        [TestCase("IANPYN", null, ExpectedResult = "ISBN 978-2-93286-181-3, Alesya - CLR via C#, Eversev, 2005, 20 pages")]
        [TestCase("IANPY", null, ExpectedResult = "ISBN 978-2-93286-181-3, Alesya - CLR via C#, Eversev, 2005")]
        [TestCase("IANP", null, ExpectedResult = "ISBN 978-2-93286-181-3, Alesya - CLR via C#, Eversev")]
        [TestCase("IAN", null, ExpectedResult = "ISBN 978-2-93286-181-3, Alesya - CLR via C#")]
        [TestCase("IA", null, ExpectedResult = "ISBN 978-2-93286-181-3, Alesya")]
        public string ToString_WithProvider_FormatTest(string format, IFormatProvider formatProvider)
        {
            formatProvider = new CultureInfo("en-US");
            
            Book book1 = new Book("ISBN 978-2-93286-181-3", "CLR via C#", "Alesya", "Eversev", 2005, 20, 200);
            string s = book1.ToString(format, formatProvider);
            return s;
        }
    }
}
