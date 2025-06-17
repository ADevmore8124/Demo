using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class inputData
    {
        public void method1()
        {
            const int i = 1;    // fix value of variable
            int age;
            String name;
            Console.WriteLine("Enter name :");
            name=Console.ReadLine();
            Console.WriteLine("Enter Age:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name : "+name);
            Console.WriteLine("Age  : "+age);

        }
        public void method2()
        {
            // control statement

            /*
             if , if else , elseif , nested if , switch case
             */
            int i = 1;
            if (i % 2 == 0)
            {
                Console.WriteLine(i+" Even Number ");
            }
            else
            {
                Console.WriteLine(i+" Odd number ");
            }
        }
        public void method3()
        {
            char alpha = 'a';
            switch(alpha)
            {
                case 'a':
                    Console.WriteLine("a"); break;
                case 'e':
                    Console.WriteLine("e"); break;
                case 'i':
                    Console.WriteLine("i"); break;
                case 'o':
                    Console.WriteLine("o"); break;
                case 'u':
                    Console.WriteLine("u"); break;
                default:
                    Console.WriteLine("Invalid choice ");
                    break;
            }
        }
        public void method4()
        {
            int number;
            Console.WriteLine("Enter a Number :");
            number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine(number + " Number is Positive ");

            }
            else if (number < 0)
            {
                Console.WriteLine(number + " Number is Negative ");
            }
            else
            {
                Console.WriteLine(number+ " == 0");
            }

            

            // Using Switch case 
            int code = (number > 0) ? 1 : (number < 0) ? -1 : 0;

            switch (code)
            {
                case 1:
                    Console.WriteLine(number + " is Positive.");
                    break;
                case -1:
                    Console.WriteLine(number + " is Negative.");
                    break;
                case 0:
                    Console.WriteLine("The number is Zero.");
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }

            // or
            //switch (number <= 0)
            //{
            //    case true: Console.WriteLine("+Ve"); break;
            //    case false: Console.WriteLine("-Ve"); break;

            //}

            int code1 = (number %2== 0) ? 1 : (number %2!= 0) ? -1 : 0;

            switch (code1)
            {
                case 1:
                    Console.WriteLine(number + " is Even.");
                    break;
                case -1:
                    Console.WriteLine(number + " is Odd.");
                    break;
                
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }
        }

      }
}
