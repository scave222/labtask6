using System;

namespace Savings
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingAccount save1 = new SavingAccount(2000);
            SavingAccount save2 = new SavingAccount(3000);

            Console.WriteLine(save1);
            Console.WriteLine(save2);

            SavingAccount.ModifyInterestRate(5);
            save1.SavingBalance = 2000;
            save2.SavingBalance = 3000;

             Console.WriteLine(save1);
            Console.WriteLine(save2);

        }
    }
}
