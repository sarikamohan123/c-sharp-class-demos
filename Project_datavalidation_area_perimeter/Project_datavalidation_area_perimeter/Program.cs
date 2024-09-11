namespace Project_datavalidation_area_perimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
    



          Console.WriteLine("Welcome to the area and Perimeter calculator");
                {
                    do
                    {
                        double length = GetValidateDimension(" Enter length: ");
                        double width = GetValidateDimension("Enter Width: ");

                        double area = CalculateArea(length, width);
                        double perimeter = CalculatePerimeter(length, width);

                        Console.WriteLine($"Area : {area}");
                        Console.WriteLine($"Perimeter: {perimeter}");
                    }

                    while (GetValidatedContinueResponse(" Continue? (y/n)"));

                }





                // creating a method  to validate data

                static double GetValidateDimension(string prompt)
                {
                    double dimension;
                    while (true)
                    {
                        Console.Write(prompt);
                        string input = Console.ReadLine();

                        if (!double.TryParse(input, out dimension))
                        {
                            Console.WriteLine(" Error! Invalid decimal value. Try again.");
                        }
                        else if (dimension <= 0.0)
                        {
                            Console.WriteLine("Error! Number must be greater than 0.0");
                        }
                        else if (dimension > 1000000.0)
                        {
                            Console.WriteLine("Error! Number must be less than 1000000.0");

                        }
                        else
                        {
                            break;
                        }
                    }
                    return dimension;
                }


                static bool GetValidatedContinueResponse(string prompt)
                {
                    while (true)
                    {
                        Console.Write(prompt);
                        string input = Console.ReadLine().ToLower();

                        if (string.IsNullOrEmpty(input))
                        {
                            Console.WriteLine("Error! This entry is required .Try again");
                        }
                        else if (input == "y")
                        {
                            return true;
                        }
                        else if (input == "n")
                        {
                            return false;
                        }
                        else
                        {
                            Console.WriteLine("Error! Entry must be 'y' or'n'.Try again");
                        }


                    }

                }

                static double CalculateArea(double length, double width)
                {
                    return length * width;
                }


                static double CalculatePerimeter(double length, double width)
                {
                    return 2 * (length + width);
                }
            }











        }
    }






    

