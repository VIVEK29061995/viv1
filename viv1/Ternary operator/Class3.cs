using System;
using System.Collections.Generic;
using System.Text;

namespace vivG
{
    class Class33
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
                Console.WriteLine("Positive");

            else if (num < 0)
                Console.WriteLine("Negative");

            else 
                Console.WriteLine("Zero");

            string msg = num > 0 ? "Positive" : num < 0 ?  "Negative" : "Zero";
            Console.WriteLine(msg);


        }
    }
}