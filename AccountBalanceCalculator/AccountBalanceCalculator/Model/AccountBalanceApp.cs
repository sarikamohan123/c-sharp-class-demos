using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBalanceCalculator.Model
{
    public class AccountBalanceApp
    {
        // the entry point of the application
        public static void Main(string[] args)
        {

            Console.WriteLine(" Welcome to the Account appication \n");

            //starting Balance

            CheckingAccount checkingAccount = new CheckingAccount(1000.00, 1.00);
            SavingsAccount savingsAccount = new SavingsAccount(1000.00, 0.01);

            Console.WriteLine(" Starting Balance");

            Console.WriteLine($"Checking : {checkingAccount.getBalance():c}");
            Console.WriteLine($" Savings   :{savingsAccount.getBalance():c}");

            Console.WriteLine("Enter the transactions for the month");

            // displaying the  transaction menu

            String continueTransaction = "y";
            while ( continueTransaction.ToLower() == "y" )
            {

                Console.Write("Withdrawal or deposit? (w/d): ");
                string transactionType = Console.ReadLine().ToLower();

                Console.Write("Checking or savings? (c/s): ");
                string accountType = Console.ReadLine().ToLower();
                Console.Write("Amount?: ");
                double amount = Convert.ToDouble(Console.ReadLine());
                if (accountType == "c")
                {
                    if (transactionType == "w")
                    {
                        checkingAccount.withdraw(amount);
                    }
                    else if (transactionType == "d")
                    {
                        checkingAccount.deposit(amount);
                    }

                    Console.Write("\nContinue? (y/n): ");
                    continueTransaction = Console.ReadLine();
                }

                // Apply monthly fee and calculate interest
                checkingAccount.subtractmonthlyFee();
                double interestPayment = savingsAccount.calculateInterestPayment();

                Console.WriteLine("\nMonthly Payments and Fees");
                Console.WriteLine($"Checking fee:              {checkingAccount.getmonthlyFee():C}");
                Console.WriteLine($"Savings interest payment:  {interestPayment:C}");

                // Display final balances
                Console.WriteLine("\nFinal Balances");
                Console.WriteLine($"Checking: {checkingAccount.getBalance():C}");
                Console.WriteLine($"Savings:  {savingsAccount.getBalance():C}");
            }
        }
    }
}

