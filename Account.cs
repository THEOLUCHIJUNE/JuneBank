using System;
using System.Collections.Generic;
using System.Linq;

namespace JuneBank
{
    public class Account    
    {
        
        public string Number { get; set; }
        public string Owner { get; set; }
        public decimal Balance 
        { 
            get
            {
                decimal balance = 2000;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            }
            
           
        }

        public void NextMenu () 
        {
		    decimal balance = initialBalance;
		    Console.WriteLine("Enter 1 for Withdrawal, 2 for Deposit, 3 to DeleteAccount ");
		    int NextChoice = int.Parse(Console.ReadLine());
		    
		    switch (NextChoice) 
            {
			    case 1 : 
				    MakeWithdrawal();
				    break;
			    case 2:
				    MakeDeposit();
				    break;
			    case 3:
				    DeleteAccount();
				    break;
			
		    }
        }    
        private static int accountNumberSeed = 1234567890;

        private List<Transaction> allTransactions = new List<Transaction>();

        public void Account(string name, decimal initialBalance)
        {
            this.Owner = name;

            MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");

            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;

            NextMenu();
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            Console.WriteLine("How much would you like to deposit; ");
		               
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }        
        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            Console.WriteLine("How much would you like to withdraw; ");
		   
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }             
        
        public void DeleteAccount()
        {  
		Console.WriteLine("Goodbye: " + name);
	    }
	
    }
}