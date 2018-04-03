using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW.S._2018.Masarnouski._08
{
    public class ListBookStorage : IBookListStorage
    {
        public void Save(string path, List<Book> bookList)
        {
            using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate))
            {
                using (var writer = new BinaryWriter(stream))
                {
                    foreach (var book in bookList)
                    {
                        writer.Write(book.Isbn);
                        writer.Write(book.Name);
                        writer.Write(book.Author);
                        writer.Write(book.Publisher);
                        writer.Write(book.NumberOfPages);
                        writer.Write(book.Price);
                        writer.Write(book.Year);
                    }
                    writer.Flush();
                }
            } 
        }
    
        public List<Book> Load(string path)
        {
            using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate))
            using (var writer = new BinaryWriter(stream))
            {
                List<Book> LoadedBookList = new List<Book>();
                var reader = new BinaryReader(stream);

                while (reader.PeekChar() > -1)
                {
                    string isbn = reader.ReadString();
                    string name = reader.ReadString();
                    string author = reader.ReadString();
                    string publisher = reader.ReadString();
                    int numberOfPages = reader.ReadInt32();
                    int price = reader.ReadInt32();
                    int year = reader.ReadInt32();
                    LoadedBookList.Add(new Book(isbn,name, author, publisher, year, numberOfPages, price));
                }
                return LoadedBookList;
            }
        }
    }
}
