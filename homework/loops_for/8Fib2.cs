using System;
using System.Collections.Generic;
using System.Text;

namespace homework.loops
{
    class Fib2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many terms");
            int terms = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int n;
            for (int i = 1; i <=terms; i++)
            {
                sum = i * i;
                Console.WriteLine(sum + ",");
            }
        }
    }
}
