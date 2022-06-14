using System;
using System.Collections.Generic;
using System.Text;

namespace homework.loops
{
    class Fibo1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many terms");
            int terms = Convert.ToInt32(Console.ReadLine());
            int sum = 1;
            for(int i=1;i<=terms;i++)
            {
                sum = i * i + 1;
                Console.WriteLine(sum+",");
            }
        }
    }
}
