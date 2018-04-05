using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW.S._2018.Masarnouski._08.Bank
{
    class BankAccount
    {
        private int id;
        private decimal balance;
        private string holderName;
        private string holderSurName;
        private int bonus;
        
        public BankAccount(int id, decimal balance, string holderName, string holderSurName, int bonus)
        {
            this.id = id;
            this.balance = balance;
            this.holderName = holderName;
            this.holderSurName = holderSurName;
            this.bonus = bonus;
        }

        #region Properties
        public int Id
        {
             get { return this.id; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"{nameof(value)}  must be greater than 0");
                }

                this.id = value;
            }
        }

        public string HolderName
        {
            get { return this.holderName; }

            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException($"{nameof(value)}");
                }

                if (value == string.Empty)
                {
                    throw new ArgumentException($"{nameof(value)} must be not empty");
                }

                this.holderName = value;
            }
        }
        public string HolderSurName
        {
            get { return this.holderSurName; }

            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException($"{nameof(value)}");
                }

                if (value == string.Empty)
                {
                    throw new ArgumentException($"{nameof(value)} must be not empty");
                }

                this.holderSurName = value;
            }
        }

        public decimal Balance
        {
            get { return this.balance; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"{nameof(value)}  must be greater than 0");
                }

                this.balance = value;
            }
        }

        public int Bonus
        { get { return this.bonus; }

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"{nameof(value)}  must be greater than 0");
                }

                this.bonus = value;
            }
        }
        #endregion
    }
}
