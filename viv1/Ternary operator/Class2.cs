using System;
using System.Collections.Generic;
using System.Text;

namespace vivG
{
    class Class28
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter year");
            int year = Convert.ToInt32(Console.ReadLine());
           
            
            Console.WriteLine(year % 4 == 0 ? "leap year" :"not leap year");
            Console.WriteLine(year);
        }
    }
}
