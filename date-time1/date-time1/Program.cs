using System;

class Program
{
    static void Main()
    {
        // prompt the user for the invoice date
        Console.Write("Enter the invoice date (yyyy-MM-dd): ");
        string input = Console.ReadLine();
        DateTime invoiceDate;
        // Parse
        if (DateTime.TryParse(input, out invoiceDate))
        {
            // Calculate the payment due date by adding 30 days to the invoice date
            DateTime paymentDueDate = invoiceDate.AddDays(30);

            // Display the payment due date
            Console.WriteLine($"Invoice Date: {invoiceDate:yyyy-MM-dd}");
            Console.WriteLine($"Payment due date :{paymentDueDate:yyyy-MM-dd}");
        }
        else
        {
            Console.WriteLine($"Invalid date .Enter date in format yyyy-MM-dd");
        }
    }
}
