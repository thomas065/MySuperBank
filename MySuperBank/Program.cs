using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySuperBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Thomas Bell", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with ${account.Balance}.");
            
            account.MakeWithdrawal(160, DateTime.Now, "Massage");          

            account.MakeWithdrawal(60, DateTime.Now, "PS4 Game");

            Console.WriteLine(account.GetAccountHistory());

        }
    }
}
