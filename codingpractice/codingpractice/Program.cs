namespace codingpractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Welcome to the random number generator and the max value!");

            int maxval = 0;
            Random rand = new Random();

            for(int i =0; i<10; i++)
            {
                int dieroll =rand.Next(1,7);
                Console.WriteLine($" Die Roll :  {dieroll}");
                maxval = Math.Max(maxval,dieroll);
            }
            Console.WriteLine($" MaxVal :{maxval}");*/
















            /*  Console.WriteLine("Welcome to the random number generator and the max value!");

              int maxval = 0;
              Random rand = new Random();

              //for (int i = 0; i < 10; i++)
              while(true)
              {
                  int dieroll = rand.Next(1, 7);
                  Console.WriteLine($" Die Roll :  {dieroll}");
                  maxval = Math.Max(maxval, dieroll);

                  if (dieroll == 1)
                  {
                      Console.WriteLine(" dieroll is 1 ,exiting the game");
                      break;
                  }
              }
              Console.WriteLine($" MaxVal :{maxval}"); */
            Console.WriteLine("Welcome to the random number generator and the max value!");

            //user input
            
            Console.WriteLine(" # of  times to play?..");
            int numgames = Int32.Parse(Console.ReadLine());

            int maxval = 0;
            int total = 0;
            int count = 0;
            int gamecount = 0;
            Random rand = new Random();
            for (int i = 0; i <= numgames; i++)
            {
                Console.WriteLine($" ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine($" Game # :{i+1}");
                Console.WriteLine($" ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                while (true)
                {
                    int dieroll = rand.Next(1, 7);
                    Console.WriteLine($" Die Roll :  {dieroll}");
                    maxval = Math.Max(maxval, dieroll);
                    total = total + dieroll;
                    count++;
                    Console.WriteLine($" print total : {total}");
                    if (dieroll == 1)
                    {
                        Console.WriteLine(" dieroll is 1 ,exiting the game");
                        
                        Console.WriteLine($" ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                        break;
                        
                    }
                }
                Console.WriteLine($" MaxVal :{maxval}");
                Console.WriteLine($" Total :  {total}");
                Console.WriteLine($" count of dieroll :{count}");
                count = 0;
                total = 0;
            }







            Console.WriteLine("Bye");
        }
    }
}

