namespace Pigdice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Coding Challenge 3 – Pig Dice!");

            //  start of the choice loop
            
              string choice = "y";

              while (choice == "y")
            {

                // User input
                Console.Write(" # of  times to play?..");
            int numgames = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Here we go...");

            int maxval = 0;
            int total = 0;
            int count = 0;
            int gamecount = 0;

            // Variables to track the game with the maximum total
            int maxGameTotal = 0;
            int maxGameNumber = 0;
            // Generate random number for the dice roll game
            Random rand = new Random();
          
                for (int i = 0; i < numgames; i++)  // Corrected loop: for (i = 0; i < numgames; i++)
                {
                    Console.WriteLine($" ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine($" Game # :{i + 1}");
                    Console.WriteLine($" ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                    while (true)
                    {
                        int diceroll = rand.Next(1, 7);
                        Console.WriteLine($" Dice Roll :  {diceroll}");
                        maxval = Math.Max(maxval, diceroll);
                        total += diceroll;
                        count++;
                        Console.WriteLine($" print total : {total}");
                        if (diceroll == 1)
                        {
                            Console.WriteLine(" diceroll is 1 ,exiting the game");
                            Console.WriteLine($" ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            break;
                        }
                    }

                    Console.WriteLine($" MaxVal :{maxval}");
                    Console.WriteLine($" Total :  {total}");
                    Console.WriteLine($" count of diceroll :{count}");

                    // Check if this game's total is the highest so far
                    if (total > maxGameTotal)
                    {
                        maxGameTotal = total;
                        maxGameNumber = i + 1;
                    }
                    Console.WriteLine($" Highest score till this game:  {maxGameTotal}");
                    // Reset for the next game
                    count = 0;
                    total = 0;
                    maxval = 0;
                }

                // Print the game number and total of the game with the highest total
                Console.WriteLine(" ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n\n\n");
                Console.WriteLine(" Final Result");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine($"Number of Games played  : {numgames}");
                Console.WriteLine($" Game with the maximum total: Game #{maxGameNumber}");
                Console.WriteLine($" Maximum score across all games: {maxGameTotal}");

                // End continue loop
                Console.Write("\nContinue (y/n)? ");
                choice = Console.ReadLine();
            }

            Console.WriteLine("Bye!");
        }
    }

}

