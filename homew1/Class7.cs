using System;
using System.Collections.Generic;
using System.Text;

namespace homew1
{
    class Parentp
    {

       
        public virtual void play()
        {
            Console.WriteLine("study by reading books");
        }
    }

   
    class Child1 : Parentp
    {

       
        public override void play()
        {
            Console.WriteLine("study by listening audio");//optional
        }
    }

    class Test4
    {

        
        public static void Main()
        {
            Parentp obj;
            obj = new Parentp();
            obj.play();
            obj = new Child1();
            obj.play();
        }
    }



    public class Parentt
    {
        //method hiding
        public void display()
        {
            Console.WriteLine("parent cls");
        }
    }
    public class Childd : Parentt
    {
        public new void display()
        {
            Console.WriteLine("child cls");
        }
    }
    public class Test5
    {
        static void Main(string[] args)
        {
            Childd ob = new Childd();
            ob.display();
        }
    }



    public class Parenttt
    {
         public void write()
        {
            Console.WriteLine("parent cls");
        }
    }
    public class Childdd : Parenttt
    {
        public new void read()
        {
            Console.WriteLine("child cls");
        }
    }
    public class TestSealed
    {
        static void Main(string[] args)
        {
            Childdd ob = new Childdd();
            ob.write();
            ob.read();
        }
    }




}
