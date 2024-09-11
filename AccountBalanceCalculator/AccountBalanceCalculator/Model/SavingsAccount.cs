using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBalanceCalculator.Model
{
      public  class SavingsAccount: Account 
    {
        private double monthlyInterestRate;//instance variable

        // constructor
         public SavingsAccount(double initialbalance, double monthlyInterestRate) : base(initialbalance)
        { 
          this.monthlyInterestRate = monthlyInterestRate;
        }
        //method to calaculate interest payment

        public double calculateInterestPayment()
        {
            double interestPayment = balance * monthlyInterestRate;
            balance += interestPayment;
            return balance;

        }


    }
}
