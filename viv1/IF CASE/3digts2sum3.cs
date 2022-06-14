using System;
using System.Collections.Generic;
using System.Text;

namespace vivG
{
    class Class3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 2 digit number");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            if (n > 9 && n < 100) 
            {
                int lastdigit = n % 10;
                int firstdigit = n / 10;
                sum = lastdigit + firstdigit;
                Console.WriteLine(sum);
            }

        }
    }
}

