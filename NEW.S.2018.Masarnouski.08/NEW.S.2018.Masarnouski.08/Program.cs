using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW.S._2018.Masarnouski._08
{
    class Program
    {
        static void Main(string[] args)
        {
            ListBookStorage bookStorage = new ListBookStorage();
            //ListBookService bookService = new ListBookService(bookStorage);
            //Book book = new Book("Война и Мир", "Л.Н.Толстой", 1867, 1225, 150);
            //Book book1 = new Book("Преступление и Наказание", "Ф.Н. Достаевский", 1866, 300, 100);
            //Book book2 = new Book("Вишнёвый Сад", "А.П.Чехов", 1904, 250, 50);
            //bookService.AddBook(book);
            //bookService.AddBook(book1);
            string path = @"D:\EPAM\HW8\NEW.S.2018.Masarnouski.08\NEW.S.2018.Masarnouski.08\BooksList.dat";
            FileStream filestream = new FileStream(path, FileMode.OpenOrCreate);
            //bookStorage.Save(filestream);

            //foreach (var item in bookStorage.bookList)
            //{
            //    Console.WriteLine($"{item.name} -- {item.author} -- {item.price}");
            //}
            //Console.ReadLine();

            bookStorage.Load(filestream);
          
            //Console.WriteLine("Выберите действие:\n 1 - Простмотреть содержимое хранилища \n 2 - добавить новую книгу" +
            //    "\n 3- удалить книгу");
            //int inputValue;
            //Int32.TryParse(Console.ReadLine(), out inputValue);
            //if (inputValue == 1)
            //{
            //    bookStorage.View();
            //}
            //if (inputValue == 2)
            //{
            //    Book book = new Book();
            //    Console.WriteLine("Enter isbn:");
            //    book.Isbn = Console.ReadLine();
            //    Console.WriteLine("Enter the book Title:");
            //    book.name = Console.ReadLine();
            //    Console.WriteLine("Enter author's name:");
            //    book.author = Console.ReadLine();
            //    Console.WriteLine("Enter the name of a publihinhouse:");
            //    book.publishingHouse = Console.ReadLine();
            //    int year;
            //    Console.WriteLine("Enter the year of issue:");
            //    Int32.TryParse(Console.ReadLine(),out year);
            //    book.year = year;
            //    int price;
            //    Console.WriteLine("Enter the year of issue:");
            //    Int32.TryParse(Console.ReadLine(), out price);
            //    book.price = price;

        }

        }
    }
