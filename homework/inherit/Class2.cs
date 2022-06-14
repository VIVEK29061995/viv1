using System;
using System.Collections.Generic;
using System.Text;

namespace homework.inherit
{
    class ICICI:Bank
    {
        float roi = 12.5f;

        public ICICI()
        {
            Console.WriteLine("In ICICI default constructor");
        }
        static void Main(string[] args)
        {
            ICICI i = new ICICI();
            
            i.deposit();
            i.withdraw();
        }
    }
}
