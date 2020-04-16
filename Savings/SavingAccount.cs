using System;
namespace Savings
{
    public class SavingAccount
    {
        private static double annualInterestRate = 0.04;
        private double savingBalance;

        public SavingAccount(double startingbalance)
        {
            SavingBalance = startingbalance;
        }

        public double SavingBalance
        {
            get {return savingBalance;}
            set {savingBalance = value + CalculateMonthlyInterest(value);}
        }

        public double CalculateMonthlyInterest(double value)
        {
            return value * (annualInterestRate / 12);
        }

        public static void ModifyInterestRate(double rate){
            annualInterestRate = rate/100;
        }

        public override string ToString()
        {

            return string.Format("Saving account is {0:C}", SavingBalance);
        }
    }
}