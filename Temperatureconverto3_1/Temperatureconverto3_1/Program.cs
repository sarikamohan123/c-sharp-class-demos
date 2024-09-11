namespace Temperatureconverto3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continueConversion = true;
            Console.WriteLine("Welcome to the Temperature Convertor");
            while (continueConversion)
                //Get user Input
            {
                Console.Write("\nEnter degrees in Fahrenheit: ");
                string input = Console.ReadLine();
                if (double.TryParse(input, out double fahrenheit))
                    
                {
                    double celsius = (fahrenheit - 32) * 5 / 9;
                    Console.WriteLine($"Degrees in Celsius: {celsius:F2}");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a numeric value.");
                }
                Console.Write("\nContinue? (y/n): ");
                string continueInput = Console.ReadLine().ToLower();
                if (continueInput != "y")
                {
                    continueConversion = false;
                }


            }




            
       


            }
        }
    }

