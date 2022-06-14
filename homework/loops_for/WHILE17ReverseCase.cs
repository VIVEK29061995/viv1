using System;
using System.Collections.Generic;
using System.Text;

namespace homework.loops_for
{
    class ReverseCase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int a = Convert.ToInt32(Console.ReadLine());

            //1234
            //4321
            int c = 0;
            while(a>0)
            {
                c++;
                int p = a % 10;
                Console.Write(p);
                a = a / 10;
            }
            Console.WriteLine("\n No of Digits " + c);
        }
    }
}
