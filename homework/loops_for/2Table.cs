using System;
using System.Collections.Generic;
using System.Text;

namespace homework.loops
{
    class Table
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("enter number");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
             for (i = 1; i <= 10; i++)
            //  for(i=5;i<=50;i=i+5)
            {
                Console.Write("{0} X {1} = {2} \n", n, i, n * i);
                // Console.WriteLine($"5X"+1+"="+i);
            }
        }
    }
}
