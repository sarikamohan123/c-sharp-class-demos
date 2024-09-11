using System;

namespace Project0501diceroller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                string rollAgain;

                do
                {
                    // Roll the dice using the GenerateRandomNumber method
                    int die1 = GenerateRandomNumber(1, 6);
                    int die2 = GenerateRandomNumber(1, 6);
                    int total = die1 + die2;
                    // Display the result
                    Console.WriteLine($"Die 1: {die1}");
                    Console.WriteLine($"Die 2: {die2}");
                    Console.WriteLine($"Total: {total}");
                    // Special cases
                    if (die1 == 1 && die2 == 1)
                    {
                        Console.WriteLine("Snake eyes!");
                    }
                    else if (die1 == 6 && die2 == 6)
                    {
                        Console.WriteLine("Boxcars!");
                    }
                    // Ask if the user wants to roll again
                    Console.Write("\nRoll again? (y/n): ");
                    rollAgain = Console.ReadLine();

                } while (rollAgain.ToLower() == "y");

                Console.WriteLine("Thanks for playing!");
            }
            //Custom method to generate a random number within a specified range
              static int GenerateRandomNumber(int minValue, int maxValue)
            {
                Random random = new Random();
            
                return random.Next(minValue, maxValue + 1);
            }
        }
    }
    
}
