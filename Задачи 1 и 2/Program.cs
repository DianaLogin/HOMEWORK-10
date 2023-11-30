using System;

namespace Задачи_1_и_2
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //============================================ Задача 2 ===========================================
            Console.WriteLine("О каком событии будем говорить?");
            string eevent = Console.ReadLine().ToLower();

            switch (eevent)
            {
                case "концерт":

                {    Person Diana = new Person("Диана", Interests.Концерт);
                    Diana.Concert_Event += Reaction_to_Concert; //обработчик события
                    void Reaction_to_Concert(string message)
                    {
                        Console.WriteLine("Этот концерт останется в моей памяти надолго! Правда, Глеб задержал начало концерта на 1 час...");
                    }
                }
                    break;

                case "дорама":
                    {
                        Person Gulnaz = new Person("Гульназ", Interests.Дорама);
                        Gulnaz.Dorama_Event += Reaction_to_Dorama; //обработчик события
                        void Reaction_to_Dorama(string message)
                        {
                            Console.WriteLine("Дорама наконeц-то вышла! Бегу смотреть!");
                        }

                    }
                    break;
                case "перелёт":
                    {
                        Person Oleg = new Person("Олег", Interests.Перелёт);
                        Oleg.Flight_Event += Reaction_to_Flight; //обработчик события
                        void Reaction_to_Flight(string message)
                        {
                            Console.WriteLine("Я побывал в Корее. Увидел красивых кореянок.");
                        }
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Это событие не интересует никого(");
                    }
                    break;

            }

        }









    }
}
