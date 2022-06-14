using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.NewFolder
{
    class Fibo10
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1;
            Console.Write("How many terms ");
            int terms = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= terms; i++)
            {
                int c = a + b;

                a = b;
                b = c;

            }
            Console.Write(a + " ");
        }
    }
    class solution
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int c = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    c++;
            }
            if (c == 2)
            {
                Console.WriteLine("prime");
            }
            else
                Console.WriteLine("not prime");
        }
    }
    class MyApplication
    {
        static void Main(string[] args)
        {

            // set the value of the three numbers
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            if (a > b && a > c)
            {


                Console.Write("max num is" + a);
            }
            else if (b > a && b > c)
            {
                Console.Write("max num is" + b);
            }
            else if (c > a && c > b)
            {
                Console.WriteLine("max num is" + c);
            }
            else
                Console.WriteLine("invalid operation");


        }
    }
    class anagram
    {
        static void Main()
        {

            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            char[] char1 = input1.ToLower().ToCharArray();
            char[] char2 = input2.ToLower().ToCharArray();

            Array.Sort(char1);
            Array.Sort(char2);

            string NewInput1 = new string(char1);
            string NewInput2 = new string(char2);
            if (NewInput1 == NewInput2)
            {
                Console.WriteLine("Both the strings are Anagrams");
            }
            else
                Console.WriteLine("Both the strings are not Anagrams");
        }
    }
    class strtogg
    {
        static void Main()
        {
            //ip = sTrinG,ComPuTEr
            //OP = StRINg,cOMpUteR
            string input = Console.ReadLine();
            for(int i=0;i<input.Length;i++)
            {
                if(input[i]>=65 && input[i]<=90)
                {
                    Console.Write((char)(input[i]+32));
                }
                else if (input[i] >= 97 && input[i] <= 122)
                {
                    Console.Write((char)(input[i]-32));
                }
            }
        }
    }
    class Occurance
    {
        static void Main()
        {
            int count = 0;
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            string[] s = input1.Split();
            
            for(int i=0;i<s.Length;i++)
            {
                if(input2== s[i])
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }

}
    