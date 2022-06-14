using System;
using System.Collections.Generic;
using System.Text;

namespace vivG
{
    class discount
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("enter the initial price");
            int bill = Convert.ToInt32(Console.ReadLine ());
            int discount = (bill * 20 / 100);
            int netpay = bill - discount;
            Console.WriteLine(" discount is= " + discount);
            Console.WriteLine("netpay is=" + netpay);
        }
    }
}
