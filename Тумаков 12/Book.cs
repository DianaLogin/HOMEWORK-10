using System;

namespace Тумаков_12
{
    internal class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Release { get; set; }
        public Book(string name, string author, string release)
        {
            Name = name;
            Author = author;
            Release = release;
        }

        // Методы для сравнения по разным полям класса Book
        public static int Compare_Name(Book book_1, Book book_2)
        {
            return book_1.Name.CompareTo(book_2.Name);
        }

        public static int Compare_Author(Book book_1, Book book_2)
        {
            return book_1.Author.CompareTo(book_2.Author);
        }

        public static int Compare_Release(Book book_1, Book book_2)
        {
            return book_1.Release.CompareTo(book_2.Release);
        }

    }
}
