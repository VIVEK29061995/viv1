using System;
using System.Collections.Generic;
using System.Text;

namespace homework.loops_for
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            int a = Convert.ToInt32(Console.ReadLine());
            int n = a;
            int rev = 0;
            while(a>0)
            {
                int d = a % 10;
                rev = rev * 10 + d;
                a = a / 10;

            }
            if(rev==n)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not Palindrome");
        }
    }
}
