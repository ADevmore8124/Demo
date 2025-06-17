using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Program
    {
        public static void m1()
        {
            int a = 20;
            int b = 30;
            Console.WriteLine("Addition is :" + (a + b));
            Console.WriteLine("Substration is :" + (a - b));
            Console.WriteLine("Multiplication is :" + (a * b));
            Console.WriteLine("Division is :" + (a / b));

            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            //inputData obj = new inputData();
            //  obj.method1();
            //   obj.method2();
            //  obj.method4();

            //Temperature t = new Temperature();
            //t.inputTemp();

            //simpleATM s = new simpleATM();
            //s.atm();
            
            BillGenration b=new BillGenration();
           b.calBill();
            Console.ReadLine();
        }
    }
}
