
namespace HOMEWORK_10
{
    internal class Building
    {
        private static int unicNumber = 0;//Статистическое поле для хранения последнего использованного номера здания

        public readonly uint number;
        public readonly double height;
        public readonly uint floors;
        public readonly uint apartments;
        public readonly uint enters;

        internal Building() { }
        internal Building(double height)
        {
            unicNumber++;
            this.height = height;
        }

        internal Building(double height, uint floors)//Ну а по факту это конструктор класса 
        {
            unicNumber++;
            this.height = height;
            this.floors = floors;
        }

        internal Building(double height, uint floors, uint apartments)//Ну а по факту это конструктор класса 
        {
            unicNumber++;
            this.height = height;
            this.floors = floors;
            this.apartments = apartments;
           
        }

        /// <summary>
        /// Метод, увеличивающий значение статистического поля
        /// </summary>
        internal Building(double height, uint floors, uint apartments, uint enters)//Ну а по факту это конструктор класса 
        {
            unicNumber++;
            this.height = height;
            this.floors = floors;
            this.apartments = apartments;
            this.enters = enters;
        }

        //Методы для установки значений каждого из полей класса 
        public double GetNumber()
        {
            return number;
        }

        public double GetHeight()
        {
            return height;
        }

        public uint GetFloors()
        {
            return floors;
        }

        public uint GetApartments()
        {
            return apartments;
        }

        public uint GetEnters()
        {
            return enters;
        }



        /// <summary>
        /// Метод для вычисления высоты этажа
        /// </summary>
        /// <returns></returns>
        public double CalculateFloorHeight()
        {
            return height / floors;
        }

        /// <summary>
        /// Метод для вычисления количества квартир в подъезде
        /// </summary>
        /// <returns></returns>
        public uint CalculateApartmentsInEnter()
        {
            return apartments / enters;
        }

        /// <summary>
        /// Метод для вычисления количества квартир на этаже
        /// </summary>
        /// <returns></returns>
        public uint CalculateApartmentsInFloor()
        {
            return apartments / floors;
        }
    }
}
