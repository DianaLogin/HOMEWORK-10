using System;


namespace Тумаков_12
{
    internal class Book_Box
    {

        public Book[] Books {  get; set; }

        public Book_Box(Book[] books)
        {
            Books = books;
        }

        // public delegate int Comparison<in Book>(Book book_1, Book book_2); --Представляет метод, сравнивающий два объекта одного типа.

        /// <summary>
        /// Метод сортировки книг в массиве
        /// </summary>
        /// <param name="comparison"></param>
        public void SortBooks(Comparison<Book> example)//в качестве параметра стоит экземпляр делегата
        {
            Array.Sort(Books, example);
        }

        /// <summary>
        /// Метод вывода на консоль информации о каждой книге массива 
        /// </summary>
        /// <param name="books"></param>
        public static void Print_Sorted_Books(Book[] books)
        {
            foreach (Book book in books)
            {
                Console.WriteLine($"Название: {book.Name}, Автор: {book.Author}, Издательство: {book.Release}");
            }
        }
    }
}
