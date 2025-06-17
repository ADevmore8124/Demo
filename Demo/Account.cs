using System;

namespace Demo
{
    internal class Account
    {
        private int CN, pin;
        private double CB = 2000; // Current balance
        private double SB = 1000; // Saving balance
        private double amount;

        public void setCustomerNumber(int cn)
        {
            CN = cn;
        }

        public void setCustomerPin(int p)
        {
            pin = p;
        }

        public int getCustomerNumber()
        {
            return CN;
        }

        public int getCustomerPin()
        {
            return pin;
        }

        public string getCurrentBalance()
        {
            return CB.ToString("0.00");
        }

        public string getSavingBalance()
        {
            return SB.ToString("0.00");
        }

        public void getCurrentWithdrawInput()
        {
            Console.WriteLine("Your Current Balance: ₹" + CB);
            Console.Write("Enter the amount to withdraw: ₹");
            amount = Convert.ToDouble(Console.ReadLine());

            if ((CB - amount) >= 0)
            {
                CB -= amount;
                Console.WriteLine("✅ Transaction Successful.");
                Console.WriteLine("New Current Balance: ₹" + CB);
            }
            else
            {
                Console.WriteLine("❌ Insufficient balance.");
            }
        }

        public void getSavingWithdrawInput()
        {
            Console.WriteLine("Your Saving Balance: ₹" + SB);
            Console.Write("Enter the amount to withdraw: ₹");
            amount = Convert.ToDouble(Console.ReadLine());

            if ((SB - amount) >= 0)
            {
                SB -= amount;
                Console.WriteLine("✅ Transaction Successful.");
                Console.WriteLine("New Saving Balance: ₹" + SB);
            }
            else
            {
                Console.WriteLine("❌ Insufficient balance.");
            }
        }

        public void getCurrentDepositeInput()
        {
            Console.WriteLine("Your Current Balance: ₹" + CB);
            Console.Write("Enter the amount to deposit: ₹");
            amount = Convert.ToDouble(Console.ReadLine());

            CB += amount;
            Console.WriteLine("✅ Deposit Successful.");
            Console.WriteLine("New Current Balance: ₹" + CB);
        }

        public void getSavingDepositInput()
        {
            Console.WriteLine("Your Saving Balance: ₹" + SB);
            Console.Write("Enter the amount to deposit: ₹");
            amount = Convert.ToDouble(Console.ReadLine());

            SB += amount;
            Console.WriteLine("✅ Deposit Successful.");
            Console.WriteLine("New Saving Balance: ₹" + SB);
        }
    }
}
