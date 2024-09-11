using System.Numerics;

namespace employee_interface_inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the world of interfaces and inheritance");

            // Create Employee object
             Employee emp = new Employee("John Doe", " union", 2342, 25.50m,40);
            Employee emp2 = new Employee("Lekha Nair", "Houston", 2347, 30.50m, 40);
            emp.PrintLabel();
            emp2.PrintLabel();
            Console.WriteLine();

            // Create Contractor object
            Contractor contractor = new Contractor("Jane Smith","Florence", 2343 ,35,23.30m);
            contractor.PrintLabel();
            Console.WriteLine();

            // Create Manager object
            Manager manager = new Manager("Alice Johnson", "Burlington", 2344, 40.50m, 40, 500.00m);
            manager.PrintLabel();
            Console.WriteLine();

            // Create Vendor object
            Vendor vendor = new Vendor("XYZ Supplies","Hebron", 2345,2050.50m);
            vendor.PrintLabel();
        }
    }
}

        
        
        

      
    

