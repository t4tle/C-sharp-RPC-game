using System;

namespace Banking
{
    class Account
    {
        //feilds / state

        //(access modifier) (type) (name) (initial value)
        private double balance;
        private int accountNumber;

        private string owner;

        private int accountNumberSeed = 34254642342;

        //Constructor -the set of instructio

        public Account(double initialBalance, String owner)
        {
            this.accountNumber =accountNumberSeed;
            accountNumberSeed++;
            
            MakeDeposit(initialBalance);
            this.owner = owner;
        }

        //Meathods / behavior
        //(access modifier) (Return type) (name) (parameters)

        public string DisplayBalance()
        {
            String BalanceString = balance.ToString();
            return BalanceString;
        } 

        public void MakeDeposit(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "amount must be greater than zero");
            }
            else
            {
              balance += amount;  
            }
            
        }
        public void MakeWithdrawl(double amount)
        {    
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "amount must be greater than zero");
            }
            else if(balance - amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Insufficient funds");
            }
            else
            {
                balance -= amount;  
            }
            
        }
    }
}