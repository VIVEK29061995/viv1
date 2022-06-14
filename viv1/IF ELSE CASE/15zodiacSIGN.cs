using System;
using System.Collections.Generic;
using System.Text;

namespace vivG
{
    class Class15
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter dd");
            int dd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter month (1-12)");
            int mm = Convert.ToInt32(Console.ReadLine());

            //Aries (March 21 – April 19)
            if ((mm==3 && dd>=20 && dd<=31) || (mm==4 && dd<=19 && dd <= 30))
                  Console.WriteLine("your zodiac sign is aries");

            //Taurus (April 20 – May 20)
            else if ((mm == 4 && dd >= 20 && dd <= 30) || (mm == 5 && dd <= 20 && dd <= 30))
                Console.WriteLine("your zodiac sign is taurus");

            //Gemini(May 21 – June 20)
            else if ((mm == 5 && dd >= 21) || (mm == 6 && dd <= 20))
                Console.WriteLine("your zodiac sign is gemini");

            //Cancer(June 21 – July 22)
            else if ((mm == 6 && dd >= 21) || (mm == 7 && dd <= 22))
                Console.WriteLine("your zodiac sign is cancer");

            //Leo (July 23 – August 22)
            else if ((mm == 7 && dd >= 23) || (mm == 8 && dd <= 22))
                Console.WriteLine("your zodiac sign is leo");

            //Virgo (August 23 – September 22)
            else if ((mm == 8 && dd >= 23) || (mm == 9 && dd <= 22))
                Console.WriteLine("your zodiac sign is virgo");

            //Libra(September 23 – October 22)
            else if ((mm == 9 && dd >= 23) || (mm == 10 && dd <= 22))
                Console.WriteLine("your zodiac sign is libra");

            //Scorpio (October 23 – November 21)
            else if ((mm == 10 && dd >= 23) || (mm == 11 && dd <= 22))
                Console.WriteLine("your zodiac sign is scorpio");

            //Sagittarius (November 22 – December 21)
            else if ((mm == 11 && dd >= 22) || (mm == 12 && dd <= 21))
                Console.WriteLine("your zodiac sign is sagittarius");

            //Capricorn (December 22 – January 19)
            else if ((mm == 12 && dd >= 22) || (mm == 1 && dd <= 19))
                Console.WriteLine("your zodiac sign is capricorn");

            //Aquarius (January 20 – February 18)
            else if ((mm == 1 && dd >= 20) || (mm == 2 && dd <= 18))
                Console.WriteLine("your zodiac sign is aquarius");

            //Pisces (February 19 – March 20)
            else if ((mm == 2 && dd >= 19) || (mm == 3 && dd <= 20))
                Console.WriteLine("your zodiac sign is pisces");

            else
                Console.WriteLine("invalid dates");
        }
    }
}
