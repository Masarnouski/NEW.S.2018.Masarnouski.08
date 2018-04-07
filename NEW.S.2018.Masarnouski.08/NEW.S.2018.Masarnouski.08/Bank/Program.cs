using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW.S._2018.Masarnouski._08.Bank
{
    class Program
    {
        static void Main()
        {
            BankAccount account = new BankAccount(1, "Eugene", "Masarnouski", 100, AccountType.Base);
            BankAccount account2 = new BankAccount(1, "Alesya", "Dzehachova", 200, AccountType.Premium);
        }
    }
}
