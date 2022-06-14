using System;
using System.Collections.Generic;
using System.Text;

namespace homework.inherit
{
    class Bank
    {
        int accno;
        string name;

        public string Name { get => name; set => name = value; }
        public int Accno { get => accno; set => accno = value; }

        internal void withdraw()
        {
            Console.WriteLine("in Bank default constructor");
        }
        internal void deposit()
        {
            Console.WriteLine("in deposit");
        }
    }
}
