using System;
using System.Collections.Generic;
using System.Text;

namespace programday1
{
	class Organization
    {
		internal static string Orgname = "LTI"; //static variable
		string City = "Chennai"; //non static variable

		internal static void GetOrgDetails()
        {
			int value = 90;
			Console.WriteLine(Orgname);
			//Console.WriteLine(City); //Error it can only access static variables

        }
    }

	class Employee
	{
		//Property
		int Eid { get; set; }
		string? Empname { get; set; }
		string? Location { get; set; }
		int Salary { get; set; }
		int Did { get; }   //Read only property

		//Constructor
		//Initialize values for the variables
		Employee()
		{
			Did = 101;
		}
		//Constructor Overloading
		Employee(int Eid, string Empname, string Location, int sal)
		{
			//this represents current class instance(employee) variable
			this.Eid = Eid;
			this.Empname = Empname;
			this.Location = Location;
			Salary = sal;
		}

		void DisplayEmployee(Employee emp)
		{
			Console.WriteLine("Eid:{0} || EmpName:{1} || Location{2} || Salary{3} || did:{4}",
				Eid, Empname, Location, Salary, emp.Did,Organization.Orgname);

		}

		static void Main()
        {
			int Empid, Esalary;
			string Elocation, Ename;
			Employee employee = new Employee();

			//Property
			/*employee.Eid = 1001;
			employee.Empname = "ANU";
			employee.Location = "CHENNAI";
			employee.Salary = 67000;
			// employee.Did=101;       //error its read
			Console.WriteLine("eid:{0} ename:{1} location:{2} salary:{3} did;{4}",
				employee.Eid, employee.Empname, employee.Location, employee.Salary, employee.Did); */

			//constructor

			int n = 2;
			//Array of objects
			Employee[] employee1 = new Employee[n];
			for (int i = 0; i<n; i++)
			{
				Console.WriteLine("Enter the Eid");
				Empid = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Enter the name");
				Ename = Console.ReadLine();
				Console.WriteLine("Enter the Location");
				Elocation = Console.ReadLine();
				Console.WriteLine("Enter the Salary");
				Esalary = Convert.ToInt32(Console.ReadLine());

				employee1[i] = new Employee(Empid, Ename, Elocation, Esalary);

			}
			//Employee employee1 = new Employee(Empid, Ename, Elocation, Esalary);

			for (int i = 0; i<n; i++)
			{
				employee1[i].DisplayEmployee(employee);
			}

			//calling static method
			Organization.GetOrgDetails();

		}
	}


}
