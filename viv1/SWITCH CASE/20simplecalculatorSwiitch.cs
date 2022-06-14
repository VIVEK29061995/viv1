using System;
using System.Collections.Generic;
using System.Text;

namespace vivG
{
    class Class20
    {
        static void Main(string[] args)
        {
            
           Console.WriteLine("enter two values");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result = 0;

            Console.WriteLine("Enter 1 for Addition");
            Console.WriteLine("Enter 2 for Subtraction");
            Console.WriteLine("Enter 3 for Multiplition");
            Console.WriteLine("Enter 4 for Division");
            int ch = Convert.ToInt32(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    {
                        result = num1 + num2;
                        Console.WriteLine("Addition: " + result);
                        break;

                    }
                case 2:
                    {
                        result = num1 - num2;
                        Console.WriteLine("Subtraction: " + result);
                        break;

                    }
                case 3:
                    {
                        result = num1 * num2;
                        Console.WriteLine("Multiplition: " + result);
                        break;

                    }
                case 4:
                    {
                        result = num1 / num2;
                        Console.WriteLine("Division: " + result);
                        break;

                    }
                default:
                    Console.WriteLine("invalid number,EnterNUM WITHIN(1-4)");
                    break;
            }
        }
    }
}

           