using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW.S._2018.Masarnouski._08.Books.Logic.Storage
{
    public interface IBookListStorage
    {
        List<Book> Load();
        void Save(List<Book> bookList);
    }
}
