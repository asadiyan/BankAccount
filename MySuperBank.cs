using System;
using System.Collections.Generic;
using System.Text;

namespace MySuperBank{

    class program{

        static void Main(string[] args){

            var account = new BankAccount("Hamidreza", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");
            account.MakeWithdrawal(120, DateTime.Now, "Badirkhan");
            account.MakeWithdrawal(50, DateTime.Now, "Xbox-Game");
            Console.WriteLine(account.GetAccountHistory());

        }
    }
}
