using System;
using System.Collections.Generic;

namespace CollectionDemoApp
{
	class Program
	{
		static void Main(string[] args)
		{
			#region Array
			//declare array
			//datatype [] name = new datatype[size]

			int[] numArray = new int[3];
			numArray[0] = 23;
			numArray[1] = 4;
			numArray[2] = 45;

			Array.Sort(numArray);

			for (int i = 0; i < numArray.Length; i++)
			{
				Console.WriteLine(numArray[i]);
			}

			//declsre srrsy snd initialize on same line
			//datatype[] name = { , , , , };

			int[] numsArray = { 23, 43, 56 };
			for (int i = 0; i < numsArray.Length; i++)
			{
				Console.WriteLine(numsArray[i]);
			}

			#endregion


			#region System.Collections
			//ArrayList countryList = new ArrayList();
			//countryList.Add("India");
			//countryList.Add("Japan");
			//countryList.Add("USA");
			//countryList.Insert(1, "Turkey");
			//countryList.Add(100);
			//countryList.Add(true);

			////object initializer
			////Person person = new Person() { FirstName = "Shahnawaz", LastName = "Shaikh" };



			//countryList.Add(new Person() { FirstName = "Shahnawaz", LastName = "Shaikh" });
			//Console.WriteLine(((Person)countryList[6]).FirstName);
			////for (int i = 0; i < countryList.Count; i++)
			//{
			//	Console.WriteLine(i + " "+countryList[i]);
			//}


			#endregion

			#region Generic 

			//Array->ArrayList->List<T>

			//List<string> countryName = new List<string>();
			//countryName.Add("India");
			//countryName.Add("Turkey");

			//List<Person> PersonList = new List<Person>();
			//PersonList.Add(new Person { FirstName = "Shah", LastName = "Shaikh" });

			//Console.WriteLine(PersonList[0].FirstName);


			#endregion


			#region Nullable Type

			//value type
			//structure
			//bool,byte,short,int,long,double,float,decimal
			//Nullable type work only with value type

			//int num1 = 10;
			////num1=null;

			//Nullable<int> x = null; //nullabletype 
			//x = 100;
			//int? y = null; //nullable type
			//y = 20;

			//if (x.HasValue)
			//{
			//	Console.WriteLine(x);
			//}
			//else {

			//	Console.WriteLine("x is null");
			//}

			//Console.WriteLine("Addition = " + (x.GetValueOrDefault(0) + y.GetValueOrDefault(0)));
			#endregion

			#region Delegate
				



			#endregion
		}


	}
}
