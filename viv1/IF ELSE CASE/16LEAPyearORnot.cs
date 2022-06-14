using System;
using System.Collections.Generic;
using System.Text;

namespace vivG
{
    class Class16
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter year");
            int year = Convert.ToInt32(Console.ReadLine());
            if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))
            { 
                Console.WriteLine(year + "is a leap year");
            }
            else
            {
                Console.WriteLine(year + "is not leap year");
            }
            Console.WriteLine();
        }

    }
}
