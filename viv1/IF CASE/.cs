using System;
using System.Collections.Generic;
using System.Text;

namespace vivG
{
    class Class6
    {

        static void Main(string[] args)
        {
            Console.WriteLine("enter 2 number");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
                Console.WriteLine($"Max={a}");
        }
    }
}
