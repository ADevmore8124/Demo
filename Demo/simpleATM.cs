using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class simpleATM
    {
        public void atm()
        {
            double initial_bal = 2000, amount;

            while (true)
            {
                Console.WriteLine("----*Menu ------* \n0.Exit\n1.Check Balance \n2.Deposit \n3.Withdraw Amount ");
                Console.WriteLine("Enter your Choice := ");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine(initial_bal);
                        break;
                    case 2:
                        Console.WriteLine("Enter amount want to deposit := ");
                        amount = Convert.ToDouble(Console.ReadLine());
                        initial_bal += amount;
                        break;
                    case 3:
                        Console.WriteLine("Enter amount want to withdraw := ");
                        amount = Convert.ToDouble(Console.ReadLine());
                        if (amount < initial_bal)
                        {
                            initial_bal -= amount;
                            Console.WriteLine("remaining balance is := " + initial_bal);
                        }
                        else { Console.WriteLine("Insufficient Balance "); }
                        break;
                    case 0:
                        Console.WriteLine("Exit");
                        return;
                    default:
                        Console.WriteLine("Invalid Choice ! try Again ");
                        break;
                }
            }
        }
    }
}
