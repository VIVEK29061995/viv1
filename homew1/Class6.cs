using System;
using System.Collections.Generic;
using System.Text;

namespace homew1
{
    class Parent
    {
        public virtual void play()
        {
            Console.WriteLine("play on ground");
        }
        internal virtual void study()
        {
            Console.WriteLine("study by reading books");
        }
    }
    class Child:Parent
    {

        public override void play()
        {
            Console.WriteLine("study by listening audio");
        }
        internal override void study()
        {
            Console.WriteLine("study hard");
        }
        class Test5
        {
            static void Main(string[] args)
            {
                Parent p2 = new Child();
                p2.study();
            }
        }
    }
   
}
