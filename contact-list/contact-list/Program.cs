

namespace contact_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to the Contact List Application");
            string choice = "Y";// Initialize choice varible
            while (choice.ToUpper() == "Y")
            //start a loop to enter contact information as long as user enters "y" or "Y"
            {
                // aSk for the user input to create a new contact
                Console.Write(" Enter First Name :");
                string? firstName = Console.ReadLine();

                Console.Write("\n Enter Last Name :");
                string? lastName = Console.ReadLine();

                Console.Write("\n Enter Email :");
                string? email = Console.ReadLine();

                Console.Write("\n Enter Phone :");
                string? phone = Console.ReadLine();




                // create a new contact object withe provided input
                Contact contact = new Contact(firstName, lastName, email, phone);

                //Display the  contact information
                Console.WriteLine(contact.displaycontact());

                //Ask the user if they want to continue adding more contacts
                Console.Write(" Do you want to continue? (y/n)");
                choice = Console.ReadLine();
            }
            Console.WriteLine("Thank you for using the Contact List Application");



            }
    }
}
