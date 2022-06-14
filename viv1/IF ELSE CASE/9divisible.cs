using System;
using System.Collections.Generic;
using System.Text;

namespace vivG
{
    class Class9
    {
         static void Main(string[] args)
         {
             Console.WriteLine("enter number to check number is prime or not");
             int num = Convert.ToInt32(Console.ReadLine());
             if(num%7==0)
                 Console.WriteLine("number is divisible by 7");
             else
                 Console.WriteLine("number is not divisible by 7");
         }
     }
 }
            
           /* Console.WriteLine("enter number to check number is prime or not");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 7 == 0 || num % 10 == 7)
                Console.WriteLine("buzz number");
            else
                Console.WriteLine("not buzz number");



        }
    }
}
*/
