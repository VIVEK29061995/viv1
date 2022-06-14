using System;
using System.Collections.Generic;
using System.Text;

namespace vivG
{
    class Class17
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int num = Convert.ToInt32(Console.ReadLine());
            if ((num % 5 == 0) && (num % 11 == 0))
            {
                Console.WriteLine("number is divisible by 5 and 11");
                
            }
            else
                Console.WriteLine("number is not divisible by 5 and 11");
             

        }
    }
}
