using System;
using System.Collections.Generic;
using System.Text;

namespace homework.loops_for
{
    class Neon
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int a = Convert.ToInt32(Console.ReadLine());
            int sq = a * a;
            int sum = 0;
            //a=9 
            //a sq =81
            //  a sq/a=ans
            //a=ans is neon numb
            while(sq>0)
            {
                int d = sq % 10;
                sum = sum + d;
               sq = sq / 10;
            }
            if(sum==a)
                Console.WriteLine("Neon");
            else
                Console.WriteLine("not");
        }
    }
}
