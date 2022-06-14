using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.NewFolder
{
    class str123
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a string");
           string s = Console.ReadLine();
            string str = "";
         
            
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }
            for(int i=s.Length-1;i>=0;i--)
            {
                Console.WriteLine(s[i]);
            }
            s = s.ToUpper();
            Console.WriteLine(s);
        }


        class palind
        {
            static void Main(string[] args)
            {
                
            }
            
        }
    }

    class Str121
    {
        class String
        {
            static void Main(string[] args)
            {
                string str = "VIVEK"; // the string which I want to reverse
                string reverse = "";
                int length = str.Length - 1;

                while (length >= 0)
                {
                    reverse = reverse + str[length];
                    length--;
                }

                Console.WriteLine(reverse);  // output: "KEVIV"
            }
        }
    }
    
}
