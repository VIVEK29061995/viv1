using System;
using System.Collections.Generic;
using System.Text;

namespace homework.loops_for
{
    class NumFactor2

    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
          //  int min = a < b ? a : b;
            for (int i = 1; i<=a && i<=b; i++)
            {

                if (a%i == 0 && b%i==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
