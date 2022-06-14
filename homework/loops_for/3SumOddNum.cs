using System;
using System.Collections.Generic;
using System.Text;

namespace homework.loops
{
    class SumofoddNUM
    {
        static void Main(string[] args)
        {
            int i, n, sum = 0;
            Console.Write("Input number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nThe odd numbers are :");
            for (i = 1; i <= n; i++)
            {
                Console.Write("{0} ", 2 * i - 1);
                sum += 2 * i - 1;
            }
            Console.Write("\nThe Sum of odd Number upto {0} terms : {1} \n", n, sum);
        }
    }
}
