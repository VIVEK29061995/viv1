using System;
using System.Collections.Generic;
using System.Text;

namespace homework.oops
{
    class VVK
    {
        string name = "vivek";
        int a = 90;
        static int b = 50;
        public void m1()
        {
            Console.WriteLine("m1 start "+a);
            m2();
            Console.WriteLine("m1 end");
        }
        public void m2()
        {
            Console.WriteLine(" m2 start"+a);
            m1();
            Console.WriteLine("m2 ends");
        }
        public static void m3()
        {
            Console.WriteLine("m3 start"+b);
            m4();
            Console.WriteLine("m3 end");
        }
        public static void m4()
        {
            Console.WriteLine("m4 start"+b);
            m3();
            Console.WriteLine("m4 end");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("main");
            VVK ob = new VVK();
            ob.m1();
            ob.m2();//FOR INSTANCE USE OBJECT OB
            VVK.m3();//FOR STATIC
            VVK.m4();
        }
    }
}
