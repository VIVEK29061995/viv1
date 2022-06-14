using System;
using System.Collections.Generic;
using System.Text;

namespace vivG
{
    class Class12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter passout year");
            int yr = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter qualification");
            string qua = Console.ReadLine();
            if(yr==2019 || qua=="BE") //&&
                Console.WriteLine("you will get the job");
            else
                Console.WriteLine("rejected");



        }
    }
}   
        