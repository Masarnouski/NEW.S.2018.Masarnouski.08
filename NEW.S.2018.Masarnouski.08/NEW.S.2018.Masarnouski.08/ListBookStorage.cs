using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW.S._2018.Masarnouski._08
{
  public class ListBookStorage
    {
       public List<Book> bookList = new List<Book>();
        public void Save(Stream s)
        {
            var writer = new BinaryWriter(s);
            foreach (var book in bookList)
            {
                writer.Write(book.name);
                writer.Write(book.author);
                writer.Write(book.numberOfPages);
                writer.Write(book.price);
                writer.Write(book.year);
            }
            writer.Flush();
        }
        public void Load(Stream s)
        {
            List < Book > LoadedBookList = new List<Book>();
            var reader = new BinaryReader(s);

            while (reader.PeekChar() > -1)
            {
                string name = reader.ReadString();
                string author = reader.ReadString();
                int numberOfPages = reader.ReadInt32();
                int price = reader.ReadInt32();
                int year = reader.ReadInt32();
                LoadedBookList.Add(new Book( name, author, year, numberOfPages, price));   
            }
        }
        public void View()
        {
            int i = 1;
            foreach (var item in bookList)
            {
                Console.WriteLine($"{i} Author: { item.author}, Имя автора { item.name}, Год {item.year}" +
                    $"Цена {item.price}");
                i++;
            }
            Console.ReadLine();
        }
    }
}
