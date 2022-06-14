using System;
using System.Collections.Generic;
using System.Text;

namespace homew1
{
    class Happy
    {
        static void Main(string[] args)
        {
                Console.WriteLine("enter number");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a % 2 == 1)
                    Console.WriteLine("HAPPY NUMBER");
                else
                    Console.WriteLine("NOT HAPPY");
        }
        
    }


    class Bouncy
    {
        static void Main(string[] args)
        {
            int rem = 0, c = 0, l = 0, d = 0, h = 0;
           
            Console.WriteLine("enter number");
          int a = Convert.ToInt32(Console.ReadLine());


            while(a>0)
            {
                rem = a % 10;
                c++;
            }
            if (c==1)
            {
                rem=d;
                l++;
                h++;
            }
            else if(rem<d)
            {
               rem=d;
                h++;
            }
            else if(rem>d)
            {
                rem = d;
                l++;

            }
            if(c==h)
            {
                Console.WriteLine("Increase");
            }
            else if(c==l)
            {
                Console.WriteLine("Decrease");
            }
            else
                Console.WriteLine("Bouncy");

        }
    }


    class Happy1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int n = Convert.ToInt32(Console.ReadLine());
            
            int flag = 1;
            while(n>0)
            {
                int digit = n % 10;
                if (digit%2==0)
                {
                    flag = 0;
                    break;
                    
                }
                n = n / 10;
            }
            if(flag==1)
            {
                Console.WriteLine("happu num");
            }
            else
                Console.WriteLine("not");
        }
    }
    class bncy
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter number");
            int n = Convert.ToInt32(Console.ReadLine());
            int next = n % 10;
            n = n / 10;
            bool inc = true;
            bool dec = true;
            while(n>0)
            {
                int prev = n % 10;
                if(prev>next)
                {
                    inc = false;
                }
                if(prev<next)
                {
                    dec = false;
                }
                next = prev;
                n = n / 10;
            }
            if(inc==true)
                Console.WriteLine("incre");
            else if(dec==true)
                Console.WriteLine("decr");
            else
                Console.WriteLine("bouncy");
        }
    }
}

