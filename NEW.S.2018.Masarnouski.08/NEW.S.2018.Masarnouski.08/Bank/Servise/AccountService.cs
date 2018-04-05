using NEW.S._2018.Masarnouski._08.Bank.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW.S._2018.Masarnouski._08.Bank.Servise
{
    class AccountService
    {
             private readonly List<BankAccount> AccountsList;
        IStorageFactory storage;
        public AccountService(IStorageFactory storage)
        {
            this.storage = storage;
            
        };
    }
}
