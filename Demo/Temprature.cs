using System;

namespace Demo
{
    internal class Temperature
    {
        public void inputTemp()
        {
            int choice;
            double temp;

            while (true)
            {
                Console.WriteLine("\n******** Temperature Converter ********");
                Console.WriteLine("1. Celsius to Fahrenheit");
                Console.WriteLine("2. Fahrenheit to Celsius");
                Console.WriteLine("3. Exit");
                Console.Write("Enter Choice (1-3): ");

                bool isValid = int.TryParse(Console.ReadLine(), out choice);
                if (!isValid)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
                    continue;
                }

                if (choice == 3)
                {
                    Console.WriteLine("Thank you!");
                    break;
                }

                Console.Write("Enter Temperature: ");
                temp = Convert.ToDouble(Console.ReadLine());

                convertTemp(temp, choice);
            }
        }

        public void convertTemp(double temp, int choice)
        {
            if (choice == 1)
            {
                double fahrenheit = (temp * 9 / 5) + 32;
                Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit:F2} °F");
            }
            else if (choice == 2)
            {
                double celsius = (temp - 32) * 5 / 9;
                Console.WriteLine($"Temperature in Celsius: {celsius:F2} °C");
            }
            else
            {
                Console.WriteLine("Invalid Choice.");
            }
        }
    }
}
