using System;
namespace BankEncapsulationExercise
{
    public class BankAccount
    {
        public BankAccount()
        {
        }
      //Encapsulation
        private double balance = 0;

        public void Deposit(double amount)
        {
            balance = amount;
        }
        public double GetBalance()
        {
            return balance;
        }
        public string GetBalance()
        {
            return $"${balance}";
        }
    }
}
