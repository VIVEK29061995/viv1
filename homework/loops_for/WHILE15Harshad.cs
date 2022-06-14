using System;
using System.Collections.Generic;
using System.Text;

namespace homework.loops_for
{
    class Harshad
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int a = Convert.ToInt32(Console.ReadLine());
            //a=153 = harshad niven numb
            //sum=2
            //divide  = harshad niven numb
            int sum = 0;
            int t = a;
            while(a>0)
            {
                int d = a % 10;
                sum = sum + d;
                a = a / 10;
            }
            if(t%sum==0)
            Console.WriteLine("Harshad Niven");
            else
                Console.WriteLine("Not HN");

        }
    }
}
