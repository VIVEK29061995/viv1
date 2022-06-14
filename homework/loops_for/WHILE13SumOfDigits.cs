using System;
using System.Collections.Generic;
using System.Text;

namespace homework.loops_for
{
    class SumOfDigits
    {
        static void Main(string[] args)
        {       
            Console.WriteLine("Enter Number");
            int a = Convert.ToInt32(Console.ReadLine());
            //a=2345
            //2+3+4+5
            //iteration depends o numb
            int sum = 0;
            while(a>0)
            {
                int digit = a % 10;//5
                sum = sum + digit;
                a = a / 10;//234
            }

            double avg = sum / (double)a;
            Console.WriteLine(avg);


            

        }
    }
}
