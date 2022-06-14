using System;
using System.Collections.Generic;
using System.Text;

namespace homework.loops_for
{
    class Power
    {
        static void Main(string[] args)
        {
            int output, temp;
            Console.WriteLine("");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            int b = Convert.ToInt32(Console.ReadLine());
            
            output = 1;
            temp = 1;
            while (temp<=b)
            {
                output = output * a;
                temp++;
            }
            Console.WriteLine(output);
            Console.ReadLine();
            /*for(int i=1;i<=idx;i++)
            {
                result = result * b;
            }
            Console.WriteLine(result);*/
        }
    }
}
