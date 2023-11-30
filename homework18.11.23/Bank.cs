using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework18._11._23
{
    public class Bank
    {
        protected Hashtable accounts = new Hashtable();
        public string CreateAccount(decimal balance)
        {
            BankAccount account = new BankAccount(balance);
            accounts.Add(account.ID, account);
            return account.ID;
        }

        public void CloseAccount(string accountID)
        {
            if (accounts.ContainsKey(accountID))
            {
                accounts.Remove(accountID);
            }
            else
            {
                Console.WriteLine("Account wasn't found.");
            }
        }
    }
}
