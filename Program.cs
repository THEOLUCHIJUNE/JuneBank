using System;
using System.Collections.Generic;
using System.Linq;

namespace JuneBank
{
    class Program
    {
        public static void Main(string[] args)
        {
           string name = " "; 
		   Console.WriteLine("Enter your first and last name: ");
		   name = Console.ReadLine();
           var account = new Account(name, 2000);
           Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");
        }

        
    }

    
}
