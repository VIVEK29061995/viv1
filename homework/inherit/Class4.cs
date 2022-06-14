using System;
using System.Collections.Generic;
using System.Text;

namespace homework.inherit
{
    class CarM
    {
        public string model;
        public string color;
        public int price;
        public void PrintInfo()
        {
            Console.WriteLine("Model:"+ model);
           Console.WriteLine("Color:" + color);
            Console.WriteLine("Price:" + price);
        }
    }

    class Honda: CarM //inheritance
    {
        float mileage;

        void printMileage()
        {
            Console.WriteLine("Mileage:"+mileage);
        }

        static void Main(string[] args)
        {
            Honda mycar = new Honda();
            mycar.model = "Amaze";
            mycar.price = 500000;
            mycar.color = "white";
            mycar.mileage = 22.5f;
            mycar.PrintInfo();
            mycar.printMileage();
            Console.ReadLine();


        }
    }
}
