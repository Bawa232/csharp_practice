using System;

namespace BankApp
{
	class BankAccount
	{
		//class fields
		public string AccNumber;
		public decimal balance;
		public string CusName;

		//Constructor
		public BankAccount(string AccNumber, decimal balance, string CusName)
		{
			this.AccNumber = AccNumber;
			this.balance = balance;
			this.CusName = CusName;
		}
		//method to deposit into the balance
		public void Deposit(decimal amount)
		{
			if(amount <= 0)
			{
				Console.WriteLine("Amount is too low for deposit");
			}

			balance += amount;
			Console.WriteLine($"Deposited {amount:C}. New balance is {balance:C}");
		}
		//method for withdrawal
		public void withdraw(decimal amount)
		{
			if(amount > balance)
			{
				Console.WriteLine("insufficient withdrawal amount");
			}

			balance -= amount;
			Console.WriteLine($"you've withdrawn {amount:C}. New balance is {balance:C}");
		}
		//method to check balance
		public void checkBalance()
		{
			Console.WriteLine($"Account Number: {AccNumber}");
			Console.WriteLine($"Account name: {CusName}");
			Console.WriteLine($"Account Balance {balance:C}");
		}

		static void Main()                                                    {
            		// Create an instance of BankAccount

           	 	BankAccount account = new BankAccount("123456789", 1000, "James Bawa");                                                                          account.Deposit(500);                                                 account.withdraw(200);                                                account.checkBalance();
		}
	}
}
