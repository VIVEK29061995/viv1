using System;
using System.Collections.Generic;
using System.Text;

namespace homework.loops_for
{
    class PrimeOrNot
    {
        static void Main(string[] args)
        {
            int n = 13;
            int c = 0;
            for(int divisor=2;divisor<=n/2;divisor++)
            {
                if(n%divisor==0)
                {
                    c++;

                }
            }
            if(c==0)
                Console.WriteLine("Prime");
            else
                Console.WriteLine("Not");
        }
    }
}
