using System;

namespace Тумаков_12
{
    internal class Program
    {
        static void Main(string[] args)
        {   //========================== Упражнение 12.1 ===========================

            Bank_Shet shet_1 = new Bank_Shet(123456789, 1000000);
            Bank_Shet shet_2 = new Bank_Shet(123456789, 1000000);
            Bank_Shet shet_3 = new Bank_Shet(985632323, 500);

            Console.WriteLine(shet_1 == shet_2); 
            Console.WriteLine(shet_1 != shet_3);  

            Console.WriteLine(shet_1.Equals(shet_2)); 
            Console.WriteLine(shet_1.Equals(shet_3));  

            Console.WriteLine(shet_1.ToString());
            Console.WriteLine(shet_2.ToString());
            Console.WriteLine(shet_3.ToString());

            //========================== Домашнее задание 12.1 ===========================

            Console.WriteLine("=========== Домашнее задание 12.1 ===========");

            Complex_num complex_1 = new Complex_num(1, 10);
            Complex_num complex_2 = new Complex_num(2, 1);

            Console.WriteLine($"Сумма: {complex_1 + complex_2}");
            Console.WriteLine($"Разность: {complex_1 - complex_2}");
            Console.WriteLine($"Произведение: {complex_1 * complex_2}");

            if (complex_1 == complex_2)
            {
                Console.WriteLine("Комплексные числа равны\n");
            }
            else
            {
                Console.WriteLine("Комплексные числа не равны\n");
            }

            //========================== Домашнее задание 12.2 ===========================

            Console.WriteLine("=========== Домашнее задание 12.2 ===========");

            Book[] books = new Book[]
            {
            new Book("Преступление и наказание", "Достоевский", "Литрес"),
            new Book("Мёртвые души", "Гоголь", "Школа"),
            new Book("Холстомер", "Толстой", "Глобус")
            };

            Book_Box box = new Book_Box(books);

            // Это экземпляры делегата, сравнивающие книги по полям класса Book
            Comparison<Book> Sorting_Name = Book.Compare_Name;
            box.SortBooks(Sorting_Name);

            Comparison<Book> Sorting_Author = Book.Compare_Author;
            box.SortBooks(Sorting_Author);

            Comparison<Book> Sorting_Release = Book.Compare_Release;
            box.SortBooks(Sorting_Release);

            Book_Box.Print_Sorted_Books(books);
        }
    }
}
