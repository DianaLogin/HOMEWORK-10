using System;

namespace HOMEWORK_10
{
    enum TypeBankShet
    {
        Saving,
        Current,
        Credit
    }
    internal class Bank_Shet
    {
        private static int newNumber = 0;
        public int Number { get; }
        public decimal Balance { get; set; }
        public TypeBankShet Type { get; set; }

        /// <summary>
        /// Метод, который увеличивает значение статистической переменной
        /// </summary>
        /// <returns></returns>
        public static int GenerateNumber()
        {
            int number = newNumber++;
            return number;
        }

        /// <summary>
        /// Метод для печати данных Счёта в консоль
        /// </summary>
        public void PrintShet()
        {
            Console.WriteLine($"Номер аккаунта: {Number}");
            Console.WriteLine($"Баланс: {Balance}");
            Console.WriteLine($"Тип банковского счёта: {Type}\n");
        }

        /// <summary>
        /// Метод, который переводит деньги с одного счёта на другой
        /// </summary>
        /// <param name="shet"></param>
        /// <param name="money"></param>
        public void TransferMoney(ref Bank_Shet shet_1, decimal money)
        {
            if (Balance <= money)
            {
                shet_1.Balance -= money;
                Balance += money;

            }
            else { Console.WriteLine("Недостаточно средств для перевода"); }
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        internal Bank_Shet()
        {
            Number = GenerateNumber();
        }

        /// <summary>
        /// Конструктор заполнения поля Баланс
        /// </summary>
        /// <param name="balance"></param>
        internal Bank_Shet(decimal balance)
        {
            Number = GenerateNumber();
            Balance = balance;
        }

        /// <summary>
        /// Конструктор заполнения поля Тип банковского счёта
        /// </summary>
        /// <param name="type"></param>
        internal Bank_Shet(TypeBankShet type)
        {
            Number = GenerateNumber();
            Type = type;
        }

        /// <summary>
        /// Конструктор заполнения поля Баланса и Типа банковского счёта
        /// </summary>
        /// <param name="balance"></param>
        /// <param name="type"></param>
        internal Bank_Shet(decimal balance, TypeBankShet type)
        {
            Number = GenerateNumber();
            Type = type;
            Balance = balance;
        }

        /// <summary>
        /// Метод для внесения денег Ha счёт
        /// </summary>
        /// <param name="money"></param>
        public void PlusMoney(decimal money)
        {
            if (money > 0)
            {
                Balance += money;
                Console.WriteLine($"На ваш счёт успешно начислено {money} рублей, остаток {Balance} рублей");
            }
            else
            {
                Console.WriteLine("Введите положительную сумму денег");
            }

        }

        /// <summary>
        /// Метод для снятия денег со счёта
        /// </summary>
        /// <param name="money"></param>
        public void MinusMoney(decimal money)
        {
            if (money <= Balance)
            {
                Balance -= money;
                Console.WriteLine($"С вашего счёта успешно снято {money} рублей, остаток {Balance} рублей");
            }
            else
            {
                Console.WriteLine("Недостаточно средств для снятия данной суммы\n");
            }
        }
    }
}
