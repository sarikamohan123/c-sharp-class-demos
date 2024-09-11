using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBalanceCalculator.Model
{
    public class CheckingAccount : Account
    {

        public double monthlyFee; // instance variable

        // constructor
        public CheckingAccount(double initialBalance ,double monthlyfee):base(initialBalance)
        { 
            this.monthlyFee = monthlyfee; 
        }

        //method for monthly fee

        public double getmonthlyFee()
        { 
         return monthlyFee;
        }

        //method for subtracting monthly fee

        public void subtractmonthlyFee()
        {
            balance -= monthlyFee;
        }
    }
}
