
namespace Nr6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Account account = new Account("John Doe");
            
            account.Deposit(500);
   
            account.DisplayAccountInfo();        
        }
    }
}
