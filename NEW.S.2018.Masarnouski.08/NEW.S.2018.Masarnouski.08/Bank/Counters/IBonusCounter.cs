using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW.S._2018.Masarnouski._08.Bank.Counters
{
    interface IBonusCounter
    {
        int GetBonusFromFill(BankAccount account, decimal amount);
        int GetBonusFromWithdraw(BankAccount account, decimal amount);
    }
}
