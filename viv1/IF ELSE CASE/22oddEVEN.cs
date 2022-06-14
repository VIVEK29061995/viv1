using System;
using System.Collections.Generic;
using System.Text;

namespace vivG
{
    class Class22
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
                Console.WriteLine("even:" + a);
            else
                Console.WriteLine("odd:" + a);
        }
    }
}
