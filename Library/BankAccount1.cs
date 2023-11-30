using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework18._11._23
{
    public class BankAccount1
    {
        public string ID { get; set; }
        public decimal Balance { get; set; }
        private static ulong Number = 100100100;
        private static string GenerateUniqueID()
        {
            Number++;
            return Number.ToString();
        }
        internal BankAccount1(decimal balance)
        {
            ID = GenerateUniqueID();
            Balance = balance;
        }

        public static bool operator ==(BankAccount1 account1, BankAccount1 account2)
        {
            return account1 == account2;
        }
        public static bool operator !=(BankAccount1 account1, BankAccount1 account2)
        {
            return account1 != account2;
        }
        public override bool Equals(object obj)
        {
            if ( obj == null || GetType() != obj.GetType() )
            {
                return false;
            }
            BankAccount1 account1 = (BankAccount1)obj;
            return this.Balance == account1.Balance || this.ID == account1.ID;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return $"ID: {ID} \nBalance: {Balance}";
        }
    }
}
