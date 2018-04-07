using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NEW.S._2018.Masarnouski._08.Bank.Storage;

namespace NEW.S._2018.Masarnouski._08.Bank.Factories
{
    class BinaryStorageFactory : IStorageFactory
    {
        public IStorage GetInstance()
        {
            return new BinaryStorage("BankAcoounts.dat");
        }
    }
}
