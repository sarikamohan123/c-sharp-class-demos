namespace Project0201
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Collecting User input

            Console.WriteLine("Student Registration Form");
            Console.Write("Enter first name: ");
            String firstname = Console.ReadLine();

            Console.Write("Enter last name: ");
            String lastname = Console.ReadLine();

            Console.Write("\n  Enter year of birth: ");
            string birthyear = Console.ReadLine();

            // Generating the temporary pasword
            string tempPassword = firstname + "*" + birthyear;

            // Displaying the registration complete process

            Console.WriteLine($"\nWelcome {firstname} {lastname}!");
            Console.WriteLine("Your registraion is Complete");
            Console.WriteLine($"Your temporary password is : {tempPassword}");


        }
    }
}
