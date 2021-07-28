using System;
using System.Collections.Generic;
using System.Text;

namespace programday1
{
    class DataTypes
    {
		void Types()
		{
			String name;
			int age;
			Console.WriteLine("Enter the name:");
			name = Console.ReadLine();
			Console.WriteLine("Enter the age:");
			age = Convert.ToInt32(Console.ReadLine());
			//placeholder
			Console.WriteLine("Name:{0} && Age:{1} ", name, age);

		}
	    void Add()
	    {
		    int c= 55+22;
	    }
void sub
{
int d=55-22;
}

		void TypeConversion()
		{
			//Implicit type conversion and Explicit
			//Implicit type conversion
			//int<float<double
			int num = 100;
			float petrol = num;
			double diesel = petrol;
			Console.WriteLine("Implicit type conversion:{0}", diesel);

			//Explicit type conversion

		}
		void BoxingandUnboxing()
		{
			//converting value type to reference type is boxing
			int salary = 20000; //value type
			Object obj = salary; //converting int to object
			int number = (int)obj; //converting object to int
			Console.WriteLine("BoxingandUnboxing:{0}", number);
		}
		void NullableTypes()
		{
			//Value Nullable type
			int? age = 30;
			Console.WriteLine("Age is {0}", age ?? 0);
			//Reference nullable type
			String? City = null;
			Console.WriteLine("City is {0}", City ?? "Chennai");

		}

		static void Main()
		{
			DataTypes dataTypes = new DataTypes();
			dataTypes.Types();
			Console.WriteLine("----------------------------");
			dataTypes.TypeConversion();
			Console.WriteLine("-----------------------------");
			dataTypes.BoxingandUnboxing();
			Console.WriteLine("-----------------------------");
			dataTypes.NullableTypes();
		}
	}
}
