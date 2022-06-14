using System;
using System.Collections.Generic;
using System.Text;


namespace homew1
{


    class Student
    {
        public int sid, percent;
        public string name, qualification;
        private static string trainername;

        public Student(int sid, int percent, string name, string qualification)
        {
           
            
                this.sid = sid;
                this.percent = percent;
                this.name = name;
                this.qualification = qualification;

        }
        public override string ToString()
        {
            return $"Name:{name} Qualification:{qualification} Sid:{sid} Percent:{percent} ";
        }


        static void settrainer()
        {
            trainername = "deepa mam";
        }
        static void Main(string[] args)
        {
            Student s1 = new Student(1,90,"VIVEK","BE");
            Console.WriteLine(s1.name);
            //OR
            Console.WriteLine(s1);
           
        }


    }
}
