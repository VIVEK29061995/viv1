using System;
using System.Collections.Generic;
using System.Text;

namespace homework.loops_for
{
    class Armstrong
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int a = Convert.ToInt32(Console.ReadLine());
            //a=153
            //three digit numb
            int x = a;
            int sum = 0;
            while(a>0)
            {
                int digit = a % 10;
                sum = sum + digit * digit * digit;
                a = a / 10;

            }
            if (sum == x)
                Console.WriteLine("Armstrong") ;
            else
                Console.WriteLine("not AS");
        }
    }
}
