﻿using NEW.S._2018.Masarnouski._08.Bank.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW.S._2018.Masarnouski._08.Bank.Servise
{
    class AccountService
    {
        private readonly List<BankAccount> accountsList;
        IStorageFactory storage;
        public AccountService(IStorageFactory storage)
        {
            this.storage = storage;
            accountsList = storage.GetInstance().Load();
        }

        public void AddAccount(BankAccount account)
        {
            if (ReferenceEquals(account, null))
            {
                throw new ArgumentNullException(nameof(account));
            }
            if (accountsList.Contains(account))
                throw new Exception("This account is alrady exists");
            else
                accountsList.Add(account);
            storage.GetInstance().Save(accountsList);
        }

        public void RemoveAccount(BankAccount account)
        {
            if (ReferenceEquals(account, null))
            {
                throw new ArgumentNullException(nameof(account));
            }
            if (accountsList.Contains(account))
                accountsList.Remove(account);
            else
                throw new Exception("This account is alrady exists");
        }
        public void FillAccount(BankAccount account, decimal amount)
        {
            account.Fill(amount);
        }
        public void WithdrawAccount(BankAccount account, decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Amount to fill must be greater or equal to 0");
            }
            if (ReferenceEquals(account, null))
            {
                throw new ArgumentNullException(nameof(account));
            }

            if (!accountsList.Contains(account))
            {
                throw new ArgumentException("This bank account not found.");
            }

            account.Withdraw(amount);
        }
    }
}