using System.ComponentModel.Design;
using System.Xml.Serialization;

namespace Practiceexample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets Revise All Concepts");
            // Use  escape sequence
            //1:
            /* string code = "JCPS";
             decimal price = 49.50m;
             string result = code + "\n" + price;
             Console.WriteLine($" Code: {code}  \n  Price : {price}");

             Console.WriteLine("----------------------");


             //2:
             string names = "Joe" + "\t Smith" + "\n Kate" + "\t Lewis";
             Console.WriteLine($"{names}");


             //Conversion statements that use the ToString(), Parse(), and TryParse() methods 

             decimal sales = 2578.96m;
             string stringsales = sales.ToString();
             Console.WriteLine($"Decimal to String : {stringsales}");

             sales = decimal.Parse( stringsales );
             Console.WriteLine($"String to Decimal :{sales}");
             Console.WriteLine(".............................");


              project 2-1

             Console.WriteLine("Student Registration Form");


             // Create a string variable and get the user input through keyboards and store the value in the variable
             Console.Write("Enter First Name  :");
             string firstName = Console.ReadLine();
             Console.Write("Enter Last Name  :");
             string lastname = Console.ReadLine();
             Console.Write(" Enter your Birth Year : ");
             int birthyear = Convert.ToInt32(Console.ReadLine());
             //Generate a temperoray password
             string temppwd = firstName + "*" + lastname + birthyear.ToString();
             Console.WriteLine($" Welcome {firstName} {lastname}!");
             Console.WriteLine("Your Registration is Complete");
             Console.Write($" Your temperory Passwor is : {temppwd}");


             // Project 2-2 Grade Convertor
             Console.WriteLine("Welcome to the letter Grade Converter");
             //= start continue loop
             string choice = "y";
             while (choice == "y")
             {


                 Console.Write("Enter Numerical grade : ");
                 int grade = Convert.ToInt32(Console.ReadLine());


                 if
                     (grade <= 100 && grade >= 88)
                 {
                     Console.WriteLine(" Letter Grade : A");

                 }
                 else if

                     (grade < 88 && grade >= 80)
                 {
                     Console.WriteLine(" Letter Grade  : B");

                 }

                 else if
                     (grade < 79 && grade >= 67)
                 {
                     Console.WriteLine(" Letter grade  : C");



                 }
                 else if
                   (grade < 67 && grade >= 60)
                 {
                     Console.WriteLine("Letter Grade   : D");
                 }


                 else if (grade < 60)
                 {
                     Console.WriteLine(" Letter Grade   :  F");

                 }

                 Console.Write("Continue ? (y/n)");
                 choice = Console.ReadLine().ToLower();

             } 



             // Project 2-3  Rectangle calculator

             Console.WriteLine("Welcome to the Area and Perimeter calculator");
             string choice = "y";
             while (choice == "y")
             {
                 Console.Write("Enter Length : ");
                 double length = double.Parse(Console.ReadLine());
                 Console.Write("\n Enter width : ");
                 double width = double.Parse(Console.ReadLine());
                 double area = length * width;
                 Console.WriteLine($" Area   :  {area}");
                 double perimeter = 2 * (length + width);
                 Console.WriteLine($"Perimeter  : {perimeter}");



                 //get user input to continue
                 Console.Write(" Continue ? y/n");
                 choice = Console.ReadLine().ToLower();




             }
             */


            // Project 4-4 common divisor calculator
            Console.WriteLine("Welcome to the Greatest common divisor calculator");
            string choice = "y";
            while (choice == "y")
            {
                Console.Write("Enter first number :");
                int firstNum = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number :");
                int secondNum = Int32.Parse(Console.ReadLine());
                
                if (firstNum > secondNum)
                {
                   
                  int rem = (firstNum % secondNum);
                    while (rem != 0)
                    {

                        firstNum = secondNum;
                        secondNum = rem;
                        rem = (firstNum % secondNum);
                    }

                    Console.WriteLine($" Greatest Common Divisor is : {secondNum}");


                   else
                    {
                        Console.WriteLine(" invalid data");
                    }
                }


                /* 
                 while (secondNum != 0)
{
    int remainder = firstNum % secondNum;
    firstNum = secondNum;
    secondNum = remainder;
}
Console.WriteLine($"Greatest Common Divisor is: {firstNum}");
*/
                 



            }
        }
    }
}



            


