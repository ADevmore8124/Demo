using System;
using System.Diagnostics.CodeAnalysis;

namespace Demo
{
    internal class BillGenration
    {
        public void calBill()
        {
            int price = 0, total = 0;
            int s = 0;

            while (s != 7)
            {
                Console.WriteLine("\n*********** MENU ************");
                Console.WriteLine("1.Pizza        140 Ruppes");
                Console.WriteLine("2. Burger      240 Ruppes");
                Console.WriteLine("3. Manchurian  100 Ruppes");
                Console.WriteLine("4. Vada Pav    20  Rupees");
                Console.WriteLine("5. Pani Puri   30  Rupees");
                Console.WriteLine("6. Generate Bill");
                Console.WriteLine("7. Exit");
                Console.Write("Enter Choice: ");

                int ch = Convert.ToInt32(Console.ReadLine());
                

                if (ch >= 1 && ch <= 5)
                {
                    Console.Write("Quantity: ");
                    int q = Convert.ToInt32(Console.ReadLine());

                    switch (ch)
                    {
                        case 1:
                            price += 140 * q;
                            break;
                        case 2:
                            price += 240 * q;
                            break;
                        case 3:
                            price += 100 * q;
                            break;
                        case 4:
                            price += 20 * q;
                            break;
                        case 5:
                            price += 30 * q;
                            break;
                    }
                    Console.WriteLine("Item added to bill.");
                }
                else if (ch == 6)
                {
                    total = price;
                    Console.WriteLine("\n========= BILL =========");
                    Console.WriteLine("Total Amount: " + total +" Ruppes");
                    Console.WriteLine("========================");
                }
                else if (ch == 7)
                {
                    Console.WriteLine("Thank you for visiting!");
                    s = 7;
                }
                else
                {
                    Console.WriteLine("Invalid Choice. Please choose between 1 to 7.");
                }
            }
        }
    }
}
