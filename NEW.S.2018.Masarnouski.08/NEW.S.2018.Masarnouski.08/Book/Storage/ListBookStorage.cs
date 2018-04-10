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
        string path;

        /// <summary>
        /// The path to storage
        /// </summary>
        public string Path { get { return this.path; }
            set
            {
                if (ReferenceEquals(value, null))
                    throw new ArgumentNullException($"{nameof(value)}");

                if (value == string.Empty)
                    throw new ArgumentException($"{nameof(value)} must be not empty");

                this.path = value;
            }
        }

        /// <summary>
        /// Saves list of books to storage
        /// </summary>
        /// <param name="path">The path to storage</param>
        public ListBookStorage(string path)
        {
            this.Path = path;
        }
        public void Save(List<Book> bookList)
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
    /// <summary>
    /// Liads list of books from storage
    /// </summary>
    /// <returns> List of book </returns>
        public List<Book> Load()
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
