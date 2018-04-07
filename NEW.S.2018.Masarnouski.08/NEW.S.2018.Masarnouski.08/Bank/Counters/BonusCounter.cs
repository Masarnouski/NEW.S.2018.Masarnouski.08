using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW.S._2018.Masarnouski._08.Bank.Counters
{
    class BonusCounter : IBonusCounter
    {
        private BankAccount account;
        public BonusCounter(BankAccount account)
        {
            this.account = account;
        } 
    public decimal FillPrice { get; private set; }

    public decimal WithdrawPrice { get; private set; }

        private void GetFillAmount(BankAccount account)
        {
            AccountType type = account.Type;
            switch (type)
            {
                case AccountType.Base:
                    {
                        FillPrice = 10;
                        WithdrawPrice = 8;
                        break;
                    }

                case AccountType.Gold:
                    {
                        FillPrice = 10;
                        WithdrawPrice = 8;
                        break;
                    }

                case AccountType.Premium:
                    {
                        FillPrice = 10;
                        WithdrawPrice = 8;
                        break;
                    }
                default:
                    {
                        throw new ArgumentException("No such type of bank account.", nameof(type));
                    }
            }
        }
        public int GetBonusFromFill(BankAccount account, decimal amount)
        {
            decimal result = amount / FillPrice;
            return (int)result;
        }

        public int GetBonusFromWithdraw(BankAccount account, decimal amount)
        {
            decimal result = amount / WithdrawPrice;
            return (int)result;
        }
    }
}
