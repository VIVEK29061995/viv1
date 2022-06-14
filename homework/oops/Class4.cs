using System;
using System.Collections.Generic;
using System.Text;

namespace homework.oops
{
    class Movie
    {
        int cid;
        string name;
        float amount;


        public void SetCid(int num)

        {
            cid = num;
        }
        public void SetName(string nm)
        {
            name = nm;
        }
        public void SetAmount(float p)
        {
            amount = p;
        }

        public string getName()
        {
            return name;
        }
        public float getAmount()
        {
            return amount;
        }
        public int getCid()
        {
            return cid;
        }

        class Test
        {
            static void Main(string[] args)
            {
                Movie m1 = new Movie();
                m1.SetCid(101);
                m1.SetName("vivek");
                m1.SetAmount(500);

                Console.WriteLine(m1.getName());
                Console.WriteLine(m1.getAmount());
                Console.WriteLine(m1.getCid());

            }
        }
}   }    
