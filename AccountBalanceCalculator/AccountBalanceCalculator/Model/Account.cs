using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBalanceCalculator.Model
{

    // define three interfaces -Depositable,Withdrawable and Balanceable

    //Define the Depositable interface
    public interface Depositable 
    {
        void deposit(double amount);

    }

    //defining the Withdrawable interface
    public interface Withdrawable
    {
     void withdraw (double amount);
    }
    
    // defining the Balanceable interface
    public interface Balanceable
    {
        double getBalance();
        void setBalance(double amount);
    }


    //The Account class implements all three interfaces
    public class Account: Depositable, Withdrawable, Balanceable
    {
         public double balance ;// variable

        //constructor
        public Account(double initialBalance)
        {
            balance = initialBalance;
        }
        // Methods for interface Balanceable-1

        public double getBalance()
        {
            return balance;
        }
         
            // 2
          public void setBalance(double amount)
        {

            balance = amount;
        }

        // method for the Depositable interface

         public void deposit(double amount)
        {
            if (amount >0) 
            {
              balance += amount;
            }
        }

        //Method for the Withdrawable interface

        public void withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)

            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine(" Insufficient balance for the withdrawl");
            }
        }





    }
}
