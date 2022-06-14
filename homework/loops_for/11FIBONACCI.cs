using System;
using System.Collections.Generic;
using System.Text;

namespace homework.loops_for
{
    class FIBONACCI
    {
        static void Main(string[] args)
        {
            // int a = 0, b = 1, c = 0;
            // Console.Write("{0} {1}", a, b);
            // for (int i = 2; i <= 9; i++)
            ///  {
            //  c = a + b;
            //  Console.Write(" {0}", c);
            //  a = b;
            // b = c;
            // }

            int a = 0, b = 1;
            Console.Write("How many terms ");
            int terms = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= terms; i++)
            {
               int c = a + b;
                Console.Write(a +" " );
                a = b;
                b = c;
            }
        }
    }
}
