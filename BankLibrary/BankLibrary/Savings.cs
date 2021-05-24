using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
	public  class Savings:Bank,IInterest
	{
		public Savings()
		{
		}

		public Savings(string name, double amount) : base(name, amount)
		{
			
		}

		public double CalculateInterest()
		{
			return 0; 
		}

		public override void Withdraw(double amount)
		{
			if ((Balance - amount) >= 0)
			{
				Balance -= amount;
			}
			else
			{

				//Console.WriteLine("Insufficient balance");
				throw new BankException("Insufficient balance");
			}
		}

	}
}
