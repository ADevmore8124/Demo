using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class OptionMenu : Account
    {
        Account a = new Account();
        Dictionary<int, int> data = new Dictionary<int, int>()
    {
        { 11111, 111 },
        { 22222, 222 },
        { 33333, 333 },
        { 44444, 444 },
        { 55555, 555 }
    };

        public void GetLogin()
        {
            int i = 15;
            do
            {
                try
                {
                   

                    Console.WriteLine("======================================");
                    Console.WriteLine("      Welcome To DKTE ATM ");
                    Console.WriteLine("======================================");
                    Console.Write(" Enter Account Number: ");
                    
                    setCustomerNumber(Convert.ToInt32(Console.ReadLine()));

                    Console.Write(" Enter PIN Number     : ");
                    
                    setCustomerPin(Convert.ToInt32(Console.ReadLine()));

                    int P = getCustomerNumber();
                    int Q = getCustomerPin();

                    if (data.ContainsKey(P) && data[P] == Q)
                    {
                        Console.WriteLine(" Login successfully.");
                        GetAccountType();
                        break;
                    }
                    else
                    {
                        Console.WriteLine(" Wrong account number or PIN!");
                    }
                }
                catch
                {
                    Console.WriteLine(" Invalid input. No characters allowed.");
                    i = 20;
                }

            } while (i == 15);
        }

        public void GetAccountType()
        {
            Console.WriteLine("\n======================================");
            Console.WriteLine("   Select the Account Type");
            Console.WriteLine("======================================");
            Console.WriteLine("1️ Current Account");
            Console.WriteLine("2️ Saving Account");
            Console.WriteLine("3️ Exit");
            Console.WriteLine("======================================");
            Console.Write("👉 Your Choice: ");
            Console.WriteLine("\n--------------------------------------");

            int ch = Convert.ToInt32(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    GetCurrent();
                    break;
                case 2:
                    GetSaving();
                    break;
                case 3:
                    Console.WriteLine("\n Thank You For Visiting DKTE ATM!");
                    break;
                default:
                    Console.WriteLine("\nInvalid choice. Try again.");
                    GetAccountType();
                    break;
            }
        }

        public void GetCurrent()
        {
            Console.WriteLine("\n Current Account Menu");
            Console.WriteLine("===========================");
            Console.WriteLine("1️  Check Balance");
            Console.WriteLine("2️  Withdraw Amount");
            Console.WriteLine("3️  Deposit Amount");
            Console.WriteLine("4️  Exit");
            Console.WriteLine("===========================");
            Console.Write(" Your Choice: ");
            Console.WriteLine("\n---------------------------");

            int ch1 = Convert.ToInt32(Console.ReadLine());

            switch (ch1)
            {
                case 1:
                    Console.WriteLine("Your Current Balance: " + getCurrentBalance());
                    GetAccountType();
                    break;
                case 2:
                    getCurrentWithdrawInput();
                    GetAccountType();
                    break;
                case 3:
                    getCurrentDepositeInput();
                    GetAccountType();
                    break;
                case 4:
                    Console.WriteLine("\n Thank You For Using DKTE ATM!");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    GetCurrent();
                    break;
            }
        }

        public void GetSaving()
        {
            Console.WriteLine("\n Saving Account Menu");
            Console.WriteLine("===========================");
            Console.WriteLine("1️  Check Balance");
            Console.WriteLine("2️  Withdraw Amount");
            Console.WriteLine("3️  Deposit Amount");
            Console.WriteLine("4️  Exit");
            Console.WriteLine("===========================");
            Console.Write(" Your Choice: ");
            Console.WriteLine("\n---------------------------");

            int ch2 = Convert.ToInt32(Console.ReadLine());

            switch (ch2)
            {
                case 1:
                    Console.WriteLine("Your Saving Balance: " + getSavingBalance());
                    GetAccountType();
                    break;
                case 2:
                    getSavingWithdrawInput();
                    GetAccountType();
                    break;
                case 3:
                    getSavingDepositInput();
                    GetAccountType();
                    break;
                case 4:
                    Console.WriteLine("\n Thank You For Using DKTE ATM!");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    GetSaving();
                    break;
            }
        }
    }
}
