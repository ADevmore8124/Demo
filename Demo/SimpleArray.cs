using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class SimpleArray
    {
        public void SimpleA()
        {
            int[] numbers = new int[10];

            Console.WriteLine("");
        }
        public void Simple2D()
        {
            int[,] numbers ={
                {2, 3},
                {4, 5}
            };
            //or 
            int[,] numbers2 = new int[3, 3];
            int[,] numbers3 = new int[3, 3]
            {
                { 1,2,3},
                {3,4,5 },
                {4,5,6 }
            };
            Console.WriteLine("Index [0,0] : " + numbers[0,0]);

            for(int j =0;j<numbers.GetLength(0);j++)
            {
                Console.Write("Row "+j+" : ");
                for(int i = 0;i< numbers.GetLength(1);i++)
                {
                    Console.Write(numbers[i,j]+" ");
                }
            }
        }
        public void jaggedArray()
        {
            //Create JArray for states and cities , ask user for the input
            string[][] stateCities = new string[3][];
            stateCities[0] = new string[] { "Maharashtra", "Mumbai", "Pune", "Nagpur" };
            stateCities[1] = new string[] { "Gujarat", "Ahmedabad", "Surat", "Rajkot" };
            stateCities[2] = new string[] { "Karnataka", "Bengaluru", "Mysore", "Hubli" };
            Console.Write("Enter a state name: ");
            string inputState = Console.ReadLine();
            bool found = false;

            foreach (var state in stateCities)
            {
                if (state[0]==inputState)
                {
                    Console.WriteLine("Cities in " + state[0] + ":");
                    for (int i = 1; i < state.Length; i++)
                    {
                        Console.WriteLine("- " + state[i]);
                    }
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("State not found.");
            }
        }
        public void remainderWithoutModulo()
        {
            int n1, n2;
            Console.WriteLine("Enter Number 1: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            if (n2 != 0)
            {
                int quotient = n1 / n2;
                int product = quotient * n2;
                int remainder = n1 - product;

                Console.WriteLine("Remainder = " + remainder);
            }
            else
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
        }


    }
}
