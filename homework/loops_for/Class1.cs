using System;
using System.Collections.Generic;
using System.Text;

namespace homework.loops_for
{
    class gcd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number");
           int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int b = Convert.ToInt32(Console.ReadLine());
            int gcd = 1;
            //8,24
            int min = a < b ? a : b;
            for(int i=2;i<=min;i++)
            {
                if (a % i == 0 && b % i == 0)
                    gcd = i;

            }

            Console.WriteLine("gcd");
        } 
    }

 }