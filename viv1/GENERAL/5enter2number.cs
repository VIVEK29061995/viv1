using System;
using System.Collections.Generic;
using System.Text;

namespace vivG
{
    class Class5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 2 number");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a="+a+" b="+b);
            Console.WriteLine("a={0} b={1}",a,b);
            Console.WriteLine($"a={a} b={b}");
        }
    }
}
