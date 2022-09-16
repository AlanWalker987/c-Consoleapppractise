using System;
namespace EncapsulationDemo
{
    public class Bank
    {
        //hiding class data by declaring the variable as private
        private double balance;

        //creating public setter and getter methods
        public double getBalance()
        {
            //add validation logic if needed
            return balance;
        }

        public void setBalance(double balance)
        {
            // add validation logic to check whether data is correct or not
            this.balance = balance;
        }
    }
    class BankUser
    {
        public static void Main()
        {
            Bank SBI = new Bank();
            SBI.setBalance(500);
            Console.WriteLine(SBI.getBalance());
            Console.WriteLine("Press any key to exist.");
            Console.ReadKey();
        }
    }
}