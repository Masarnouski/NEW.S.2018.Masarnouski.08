using NEW.S._2018.Masarnouski._08.Bank.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW.S._2018.Masarnouski._08.Bank.Factories
{
    interface IStorageFactory
    {
        IStorage GetInstance();
    }
}
