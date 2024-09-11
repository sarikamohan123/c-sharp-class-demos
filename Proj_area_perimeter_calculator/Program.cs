using System.Transactions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the area and Perimeter calculator");
         
            // Start continue loop

            string choice = "y";
            while (choice == "y")
            {

                // get user input
                Console.Write("Enter Length: ");
                double length = double.Parse(Console.ReadLine());

                Console.Write("\n Enter Width: ");
                double width = double.Parse(Console.ReadLine());

                // do business logic
                // calculationg area and perimeter

                double area = length * width;
                double Perimeter = 2 * (length + width);

                //print the output

                Console.WriteLine($"\nArea:         {area}");
                Console.WriteLine($"\nPerimeter:     {Perimeter}");

                // End continue loop
                Console.Write("\n continue (y/n) ?");

                choice = Console.ReadLine();
            }

            Console.WriteLine("Bye");



            
                

            

            
        }
    }
}
