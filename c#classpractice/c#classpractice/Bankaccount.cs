using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_classpractice
{
    internal class Bankaccount
    {
        //Properties
        public int AccountNumber { get; set; }
        public string AccountName { get; set; }
        public int OwnerId { get; set; }
        public decimal Balance { get; set; }
        public string BranchManager{ get; set; }
    }

    class CheckingAccount : Bankaccount
    {//Properties
        public int LastCheckNumber { get; set; }
    }

    class SavingAccount : Bankaccount 
    { //Properties
        public string Accounttype{ get; set; }

    }


    class BusinesscheckingAccount :CheckingAccount 
    {
        public string BusinessFedId { get; set; }
    }
}
