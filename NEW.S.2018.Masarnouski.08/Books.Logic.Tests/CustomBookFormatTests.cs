using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NEW.S._2018.Masarnouski._08.Books.Logic;
using System.Globalization;

namespace Books.Logic.Tests
{
    /// <summary>
    /// Сводное описание для CustomBookFormat
    /// </summary>
    [TestClass]
    public class CustomBookFormatTests
    {
        [TestMethod]
        public void Format_Where_ArgIsBook_FormatIsCustom()
        {
            var arg = new Book("ISBN 978-2-93286-181-3", "CLR via C#", "Alesya", "Eversev", 2005, 20, 200);
            var format = "Custom";
            var formatProvider = CultureInfo.CurrentCulture;
            CustomBookFormat customformat = new CustomBookFormat();
            string result = customformat.Format(format, arg, formatProvider);
            string expectedResult = "CustomBookFormat Representation ISBN 978-2-93286-181-3, Alesya - CLR via C#, Eversev, 2005, 20 pages, 200,00р.";
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Format_Where_ArgIsBook_FormatIsNull()
        {
            var arg = new Book("ISBN 978-2-93286-181-3", "CLR via C#", "Alesya", "Eversev", 2005, 20, 200);
            string format = null;
            var formatProvider = CultureInfo.CurrentCulture;
            CustomBookFormat customformat = new CustomBookFormat();
            string result = customformat.Format(format, arg, formatProvider);
            string expectedResult = "ISBN 978-2-93286-181-3, Alesya - CLR via C#, Eversev, 2005, 20 pages, 200,00р.";
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Format_Where_ArgIsInt32_FormatIsNull()
        {
            var arg = 1000;
            string format = null;
            var formatProvider = CultureInfo.CurrentCulture;
            CustomBookFormat customformat = new CustomBookFormat();
            string result = customformat.Format(format, arg, formatProvider);
            string expectedResult = "1000";
            Assert.AreEqual(expectedResult, result);
        }
    }
}
