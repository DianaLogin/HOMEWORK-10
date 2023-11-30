using System.Collections;

namespace HOMEWORK_10
{
    internal class Bank_Fabric
    {
        internal int CreateAccount()
        {
            int number = Bank_Shet.GenerateNumber();
            Bank_Shet account = new Bank_Shet();
            accounts[Bank_Shet.GenerateNumber()] = number;
            return number;
        }
        internal int CreateAccount(decimal balance)
        {
            int number = Bank_Shet.GenerateNumber();
            Bank_Shet account = new Bank_Shet(balance);
            accounts[Bank_Shet.GenerateNumber()] = number;
            return number;
        }
        internal int CreateAccount(TypeBankShet type)
        {
            int number = Bank_Shet.GenerateNumber();
            Bank_Shet account = new Bank_Shet(type);
            accounts[Bank_Shet.GenerateNumber()] = number;
            return number;
        }
        internal int CreateAccount(TypeBankShet type, decimal balance)
        {
            int number = Bank_Shet.GenerateNumber();
            Bank_Shet account = new Bank_Shet(balance,type);
            accounts[Bank_Shet.GenerateNumber()] = number;
            return number;
        }

        Hashtable accounts = new Hashtable();
        
        
        /// <summary>
        /// Метод закрытия счета, удаляющий счёт из хеш-таблицы
        /// </summary>
        internal void Close_Account(int number)
        {
            accounts.Remove(number);
        }
    }
}
