using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW.S._2018.Masarnouski._08.Bank.Storage
{
    class BinaryStorage: IStorage
    {
        public BinaryStorage()
        {

        }

        public List<BankAccount> Load(string path)
        {
            using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate))
            using (var writer = new BinaryWriter(stream))
            {
                List<BankAccount> LoadedAccountsList = new List<BankAccount>();
                var reader = new BinaryReader(stream);

                while (reader.PeekChar() > -1)
                {
                    int id = reader.ReadInt32();
                    string holderName = reader.ReadString();
                    string holderSurName = reader.ReadString();
                    decimal balance = reader.ReadDecimal();
                    int bonus = reader.ReadInt32();

                    LoadedAccountsList.Add(new BankAccount(id,balance,holderName,holderSurName,bonus));
                }
                return LoadedAccountsList;
            }
        }

        public void Save(string path, List<BankAccount> accountsList)
        {
            using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate))
            {
                using (var writer = new BinaryWriter(stream))
                {
                    foreach (var account in accountsList)
                    {
                        writer.Write(account.Id);
                        writer.Write(account.HolderName);
                        writer.Write(account.HolderSurName);
                        writer.Write(account.Balance);
                        writer.Write(account.Bonus);
                    }
                    writer.Flush();
                }
            }
        }
    }
}
