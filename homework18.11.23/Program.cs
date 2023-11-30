using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework18._11._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 11.1");
            Bank bank = new Bank();
            string account1 = bank.CreateAccount(1500);
            string account2 = bank.CreateAccount(2000);
            Console.WriteLine("Account created:" + account1);
            Console.WriteLine("Account created:" + account2);
            bank.CloseAccount(account2);
            Console.WriteLine("Account closed:" + account2);

            Console.WriteLine("\nTask 11.2");
            Bank1 bank1 = new Bank1();
            string account3 = bank1.CreateAccount(2430);
            string account4 = bank1.CreateAccount(5000);
            Console.WriteLine("Account created:" + account3);
            Console.WriteLine("Account created:" + account4);
            bank1.CloseAccount(account4);
            Console.WriteLine("Account closed:" + account4);

            Console.WriteLine("\nHome task 11.1");
            int building1 = Creator.CreateBuild(15.5);
            int building2 = Creator.CreateBuild(256, 12, 8);
            Console.WriteLine("Building created:" + building1);
            Console.WriteLine("Building created:" + building2);
            Creator.DeleteBuilding(building1);
            Console.WriteLine("Building deleted:" + building1);

            Console.WriteLine("\nTask 12.1");
            Bank1 bank2 = new Bank1();
            string user1 = bank2.CreateAccount(250);
            string user2 = bank2.CreateAccount(500);
            Console.WriteLine(user1.ToString());
            Console.WriteLine(user2.ToString());
            Console.WriteLine(user1.Equals(user2));
            Console.WriteLine($"Account 1 is equal to account 2: {user1 == user2}");

            Console.WriteLine("(Press any key to continue work)");
            Console.ReadKey();
            
        }
    }
}
