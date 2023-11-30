using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework18._11._23
{
    public class BankAccount
    {
        public string ID { get; set; }
        public decimal Balance { get; set; }
        private static ulong Number = 100100100;
        private static string GenerateUniqueID()
        {
            Number++;
            return Number.ToString();
        }
        internal BankAccount(decimal balance)
        {
            ID = GenerateUniqueID();
            Balance = balance;
        }
    }
}
