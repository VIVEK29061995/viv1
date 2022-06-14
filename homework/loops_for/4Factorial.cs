using System;
using System.Collections.Generic;
using System.Text;

namespace homework.loops
{
    class FACTORIAL
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int x = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= x; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("factorial=" + factorial);
        }
    }
}
