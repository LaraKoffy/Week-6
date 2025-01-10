namespace Nr8
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            BankAccount account = new BankAccount("123456789", 1000.00);

       
            Console.WriteLine($"Account Number: {account.AccountNumber}");
            Console.WriteLine($"Initial Balance: ${account.Balance}");

            
            Console.WriteLine("\nDeposit $500");
            account.Deposit(500);

            
            Console.WriteLine("\nWithdraw $300");
            account.Withdraw(300);

        
            Console.WriteLine("\nAttempt to withdraw $2000");
            account.Withdraw(2000);

    
            Console.WriteLine($"\nFinal Balance: ${account.Balance}");

            Console.ReadLine();
        }
    }
}
