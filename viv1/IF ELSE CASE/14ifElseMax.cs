using System;
using System.Collections.Generic;
using System.Text;

namespace vivG
{
    class Class14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER 3 NUMBERS");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
          //  a=25 b=20 c=30
            if(a>b && a>c)
                Console.WriteLine("Max:"+a);
            else if (b>a && b>c)
                Console.WriteLine("Max:"+b);
            else if (c > a && c > b)
                Console.WriteLine("Max:"+c);
            else
                Console.WriteLine("All are equal");


        }
    }
}
