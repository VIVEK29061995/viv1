using System;
using System.Collections.Generic;
using System.Text;

namespace homework.oops
{
    class Flat
    {
        int nid;
        string bname;
        int rent;
       // Owner Flatowner = new Owner;


        public int Nid { get { return nid; } set { nid = value; } }

        public string Bname { get => bname; set => bname = value; }
        public int Rent { get => rent; set => rent = value; }
       // public Owner Flatowner { get => flatowner; set => Flatowner = value; }
    }




    class Owner
    {
        public int Age
        {
            get;
            set;
        }

        public string Ownname
        {
            get;
            set;
        }

        public string Proffesion
        {
            get;
            set;
        }

        class EmpTest
        {
            static void Main(string[] args)
            {
                Flat f = new Flat();
                f.Nid = 2001;
                f.Rent = 5000;
                f.Bname = "VRUNDAVAN";
               // f.Flatowner.Age = 40;
               // f.Flatowner.

            }
        }

    }
}
