namespace c_classpractice
{
    abstract internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
            Bankaccount account = new Bankaccount();
            account.OwnerId = 1;
            account.Balance = 1000000;
            account.AccountName = "Corporate";
            account.AccountNumber = 1000;

            CheckingAccount ck1 = new();
            ck1.AccountNumber = 1234;
            ck1.OwnerId = 1;
            ck1.Balance = 1000;
            ck1.AccountName = "Toys";
            ck1.LastCheckNumber = 999;

            SavingAccount SA1 = new();  

           SA1.AccountNumber = 1234;
            SA1.OwnerId = 1;
            SA1.Balance = 10;
            SA1.AccountName = " College Fund";
            

        }
    }
}
