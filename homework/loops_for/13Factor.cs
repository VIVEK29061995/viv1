using System;
using System.Collections.Generic;
using System.Text;

namespace homework.loops_for
{
    class Factor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {

                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
