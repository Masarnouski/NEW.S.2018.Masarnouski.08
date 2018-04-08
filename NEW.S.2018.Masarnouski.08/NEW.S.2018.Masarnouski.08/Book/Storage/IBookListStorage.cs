using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW.S._2018.Masarnouski._08
{
    public interface IBookListStorage
    {
        List<Book> Load(string path);
        void Save(string path, List<Book> bookList);

    }
}
