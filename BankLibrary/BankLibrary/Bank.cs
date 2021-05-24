using System;

namespace BankLibrary
{
	public abstract class Bank
	{
		#region Fields & Property
		//AccHolderName - string
		//Balance - double

		private string accHolderName;

		public string AccHolderName
		{
			get { return accHolderName; }
			set { accHolderName = value; }
		}

		// mixed access specifiers for the property
		private double balance;

		public double Balance
		{
			get { return balance ; }
			protected set { balance = value; }
		}

		#endregion


		#region Methods
		public void Deposit(double amount)
		{
			Balance += amount;
		}

		//public virtual void Withdraw(double amount)
		//{
		//	Balance -= amount;
		//}

		public abstract void Withdraw(double amount);

		public override string ToString()
		{
			return string.Format($"Account Holder Name = {AccHolderName},Balance={Balance}");
		}
		#endregion

		#region Constructor
		//static constructor
		//no parameter
		//no access specifier
		//will be called once when class loader load the class
		public Bank()
		{
			Balance = 1000;
			Counter++;
		}

		public Bank(string name, double amount ) : this()
		{
			AccHolderName = name;
			Balance = amount;
		}


		#endregion
		//maintain total bank account object created
		#region Static int counter

		private static int counter;

		public static int Counter
		{
			get { return counter; }
			private set { counter = value; }
		}

		#endregion
	}
}