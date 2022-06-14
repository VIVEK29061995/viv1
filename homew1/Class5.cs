using System;
using System.Collections.Generic;
using System.Text;

namespace homew1
{
    class Volume
    {
        public double volume(double r)
        {
            return (4 / 3) * (22 / 7) * (r * r * r);
        }
        public double volume(double radius, double height)
        {
            return (22 / 7) * (radius * radius) * height;
        }
        public double volume(double length, double breath, double height)
        {
            return length * breath * height;
        }
    }

    class Test
    {
        static void Main(string[] args)
        {
            Volume a = new Volume();
            char  ch = 'Y';
            char ch1 = 'N';

            do
            {
                Console.WriteLine("Press 1-Cuboid,2-Cylinder,3-Sphere");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Double");
                        double sphere = a.volume(Convert.ToDouble(Console.ReadLine()));
                        Console.WriteLine("Volume of Sphere" + sphere);
                        break;
                    case 2:
                        Console.WriteLine("Enter Double");
                        double cylinder = a.volume(Convert.ToDouble(Console.ReadLine()));
                        Console.WriteLine("Volume of Sphere" + cylinder);
                        break;
                    case 3:
                        Console.WriteLine("Enter Double");
                        double cuboid = a.volume(Convert.ToDouble(Console.ReadLine()));
                        Console.WriteLine("Volume of Sphere" + cuboid);
                        break;

                }
                Console.WriteLine("Press yes to continue ,No to exit");
                ch = Convert.ToChar(Console.ReadLine());
            } while (ch == 'Y' || ch == 'y');
        }
    }



    class Order
    {
        int Orderid;
        string ordername;
        Customer c = new Customer();
        Item i = new Item();

        public string Ordername { get => ordername; set => ordername = value; }
        public int Orderid1 { get => Orderid; set => Orderid = value; }

        internal Customer C { get => c; set => c = value; }
        internal Item I { get => i; set => i = value; }
    }
    class Customer
    {
        Address addr = new Address();
        int cid;
        string name;

        public string Name { get => Name; set => Name = value; }
        
        public Address Addr { get => addr; set => addr = value; }
        public int Cid { get => cid; set => cid = value; }
    }

    class Address
    {
        int pincode;
        string city;

        public string City { get => city; set => city = value; }
        public int Pincode { get => pincode; set => pincode = value; }
    }
    class Item
    {
        int itemid;
        string iname;

        public string Iname { get => iname; set => iname = value; }
        public int Itemid { get => itemid; set => itemid = value; }
    }

    class Test1
    {
        static void Main(string[] args)
        {
            Order a = new Order();
            Console.WriteLine("ENTER FOLLOWING IN SEQUENCE:-orderid,ordername,addr city,addr pincode,customerid,customername,itemid,itemname");
            a.Orderid1 = Convert.ToInt32(Console.ReadLine());
            a.Ordername = Console.ReadLine();
            a.C.Addr.City= Console.ReadLine();
            a.C.Addr.Pincode= Convert.ToInt32(Console.ReadLine());
            a.C.Cid= Convert.ToInt32(Console.ReadLine());
            a.C.Name= Console.ReadLine();
            a.I.Iname= Console.ReadLine();
            a.I.Itemid= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Orderid1 = {a.Orderid1}, Ordername={a.Ordername}");
            Console.WriteLine($"City = {a.C.Addr.City}, Pincode={a.C.Addr.Pincode}");
            Console.WriteLine($"Customerid = {a.C.Cid}, Name={a.C.Name}");
            Console.WriteLine($"Iname = { a.I.Iname}, Itemid={a.I.Itemid}");

        }
    }
        
}
