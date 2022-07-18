using System;

namespace Banking
{

    class Program
    {
        static void main(string[] args)
        {
            Account newAccount = new Account();
            try
            {
               newAccount.MakeDeposit(110);
               Console.WriteLine(newAccount.DisplayBalance()); 
            }
            catch (Exception ex)
            {
                
               Console.WriteLine(ex.Message);
            }
            
            try
            {
                newAccount.MakeWithdrawl(50);
                Console.WriteLine(newAccount.DisplayBalance());
            }
            catch (Exception ex)
            {
                
                Console.WriteLine(ex.Message);
            }

        }
    }

}