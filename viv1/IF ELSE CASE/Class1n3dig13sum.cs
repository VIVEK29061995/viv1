using System;
using System.Collections.Generic;
using System.Text;

namespace vivG
{
    class Class1
    {
        static void Main(string[] args)
        {
            int lastdigit, sum, firstdigit;
            Console.WriteLine("Enter 3 digit number");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 99 && num < 1000)
            {
                 lastdigit = num % 10;
                //middle num =(num/10)%10
                 firstdigit = num / 100;
                 sum = lastdigit + firstdigit;
                Console.WriteLine("Entered number is 3Digit and sum of first an lastdigit is " + sum);
            }
            else
                Console.WriteLine("Entered number is not 3 digit Number");
        }
    }
}
