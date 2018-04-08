using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW.S._2018.Masarnouski._08.Interfaces
{
    public interface IFinder<Book>
    {
        Predicate<Book> Find(string other);
    }
}
