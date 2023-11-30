

namespace Тумаков_12
{
    internal class Bank_Shet
    {

        public long Number { get;}
        public decimal Balance { get;}

        public Bank_Shet(long number, decimal balance)
        {
            Number = number;
            Balance = balance;
        }

        public static bool operator ==(Bank_Shet shet_1, Bank_Shet shet_2)
        {
            if (Equals(shet_1, shet_2))
            {
                return true;
            }
            if (Equals(shet_1, null) || Equals(shet_2, null))
            {
                return false;
            }
            return shet_1.Equals(shet_2);
        }

        public static bool operator !=(Bank_Shet shet_1, Bank_Shet shet_2)
        {
            return !(shet_1 == shet_2);
        }

        public override bool Equals(object obj)
        {
            Bank_Shet other = (Bank_Shet)obj; //приведение объекта obj к типу Bank_Shet, чтобы можно было обратиться к его свойствам
            return Number == other.Number && Balance == other.Balance;
        }

        public override int GetHashCode()
        {
            return Number.GetHashCode() ^ Balance.GetHashCode(); //операция побитового исключающего ИЛИ (^) между хэш-кодами свойств Number и Balance позволяет создать уникальный хэш-код 
        }

        public override string ToString()
        {
            return $"Номер счёта: {Number}, Баланс на счёте: {Balance:$}";
        }
    }
}
