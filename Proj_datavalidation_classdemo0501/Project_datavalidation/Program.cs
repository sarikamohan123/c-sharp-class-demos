namespace Project_datavalidation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the data validation");
            int dieRoll = GetInt("Enter die roll : ");
            Console.WriteLine($"Die Roll is {dieRoll}");

            int dieRoll = GetDouble("Enter die roll : ");
            Console.WriteLine($"Die Roll is {dieRoll}");


        }
        private static int GetInt(string prompt, int min, int max)
        {

            int number = 0;

            Boolean isValid = false;



            while (!isValid)
            {

                try
                {

                    Console.Write(prompt);

                    number = Int32.Parse(Console.ReadLine());

                    if (number < min)
                    {

                        Console.WriteLine($"Invalid entry: number less than min ({min})");

                        continue;

                    }

                    else if (number > max)
                    {

                        Console.WriteLine($"Invalid entry: number greater than max ({max})");

                        continue;

                    }

                    else
                    {

                        break;

                    }

                }

                catch (Exception e)
                {

                    Console.WriteLine("Invalid entry: please enter a valid integer.");

                    continue;

                }

            }



            return number;

        }

        // GetDouble method which uses data validation
        private static double GetInt(string prompt, double min, double max)
        {

            double number = 0.0;

            Boolean isValid = false;



            while (!isValid)



                Console.Write(prompt);
            //number =Double.Parse(console.Readline());
            Boolean success = Double.TryParse(Console.ReadLine(), out number);
            if (!success)
            {
                Console.WriteLine("invalid entry: Please entry a valid double.");
            }

            else {

                if (number < min)
                {

                    Console.WriteLine($"Invalid entry: number less than min ({min})");

                    continue;

                }

                else if (number > max)
                {

                    Console.WriteLine($"Invalid entry: number greater than max ({max})");

                    continue;

                }

                else
                {

                    break;

                }



            }

        }

    }

            return number;

        }






    }
}
