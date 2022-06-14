using System;
using System.Collections.Generic;
using System.Text;

namespace homework.oops
{
  
    class Book
    {
        string name, author;
        int year,price;

        public void acceptdetails()
        {
            Console.Write("Enter book name");
            name = Console.ReadLine();

            Console.Write("Enter author");
            author = Console.ReadLine();

            Console.Write("Enter year");
            year = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter price");
            price = Convert.ToInt32(Console.ReadLine());
        }

        public void printdetails()
        {
           ;
            Console.Write("name" + name);
            Console.Write("author" + author);
            Console.Write("year" + year);
            Console.Write("price"+ price);
        }

        static void Main(string[] args)
        {
            Book B1 = new Book();
            B1.name= "LIFE";
            B1.author = "Saint koo";
            B1.price = 300;



        }
    }

}

