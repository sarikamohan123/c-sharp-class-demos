using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace employee_interface_inheritance
{

    //interface ILabel

    interface ILabel
    {
        public void PrintLabel();
    }

    class Person // base class
    {
        public string EmpName { get; set; }

        public string EmpAddress { get; set; }
        public int EmployeeId { get; set; }
        //public string vendorName {  get; set; }

        //public string vendorCode {  get; set; }

        // constructor
        public Person(string name, string address, int Id)
        {

            this.EmpName = name;
            this.EmpAddress = address;
            this.EmployeeId = Id;


        }
        public virtual void ShowDetails()
        {
            Console.WriteLine($"Name, Address, Id : {EmpName} {EmpAddress} {EmployeeId}");
        }


    }
    // Derived class Employee from class person
    class Employee : Person, ILabel
    {
        public decimal salary { get; set; }
        public decimal hourlyrate { get; set; }
        public double hoursperweek { get; set; }

        //constructor
        public Employee(string name, string address, int Id, decimal hourlyrate, int hoursperweek) : base(name, address, Id)

        {

            this.hourlyrate = hourlyrate;
            this.hoursperweek = hoursperweek;
            salary = hourlyrate * hoursperweek;
        }

        public void PrintLabel()
        {
            ShowDetails();
            Console.WriteLine($"Employee Salary: {salary:C}");
        }

    }

    class Contractor : Person, ILabel
    {

        public decimal hourlyrate { get; set; }
        public double hoursthisweek { get; set; }
        public decimal Salary { get; set; }

        //constructor

        public Contractor(string name, string address, int Id, int hoursthisweek, decimal hourlyrate) : base(name, address, Id)
        {

            this.hourlyrate = hourlyrate;
            this.hoursthisweek = hoursthisweek;
            this.Salary = hourlyrate * hoursthisweek;
        }

        public void PrintLabel()
        {
            ShowDetails();
            Console.WriteLine($"Contractor Salary: {Salary:C}");
        }

    }


        // derived class Manager from Employee
        class Manager : Employee

        {
            public decimal Bonus { get; set; }

            // constructor
            public Manager(string name, string address, int Id,  decimal hourlyrate,int hoursperweek, decimal bonus) : base(name, address, Id, hourlyrate ,hoursperweek)
            {
                this.Bonus = bonus;
            }

            public new void PrintLabel()
            {
                ShowDetails();
                Console.WriteLine($"Manager Salary: {salary:C}, Bonus: {Bonus:C}");
            }
        }


        class Vendor : Person
        {
            public decimal Amountdue { get; set; }

            public Vendor(string name, string address, int Id, decimal amountdue) : base(name, address, Id)
            {
                this.Amountdue = amountdue;
            }

            public void PrintLabel()
            {
                ShowDetails();
                Console.WriteLine($"Amount Due to Vendor: {Amountdue:C}");
            }
        }
    }



        









