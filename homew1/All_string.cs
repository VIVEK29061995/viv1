using System;
using System.Collections.Generic;
using System.Text;

namespace homew1
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

            Console.WriteLine(reverse);  // output: "KEVIV"
        }
    }
}
