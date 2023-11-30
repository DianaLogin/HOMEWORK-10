
namespace Задачи_1_и_2
{
    enum Interests
    {
        Концерт,
        Дорама,
        Перелёт
    }

    internal class Person
    {
        public string Name { get; }
        public Interests Interest { get; }
        public delegate void EventHandler(string message);
        public event EventHandler Dorama_Event, Flight_Event, Concert_Event; //ОПРЕДЕЛЕНИЕ СОБЫТИЙ

        /// <summary>
        /// Конструктор класса Person
        /// </summary>
        /// <param name="name"></param>
        /// <param name="interest"></param>
        public Person(string name, Interests interest)
        {
            Name = name;
            Interest = interest;
        }
    }
}



