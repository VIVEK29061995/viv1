using System;
using System.Collections.Generic;
using System.Text;

namespace homework.oops
{
    class Employee
    {
        int empid;
        string name;
        int salary;
        Dept department = new Dept();
        
        public int Empid { get { return empid; } set { empid = value; } }

        public string Name { get => name; set => name = value; }
        public int Salary { get => salary; set => salary = value; }
        public Dept Department { get => department; set => department = value; }
    }




    class Dept
    {
        public int Deptid
        {
            get;
            set;
        }

        public string Deptname
        {
            get;
            set;
        }

        public string Manager
        {
            get;
            set;
        }

        class EmpTest
        {
            static void Main(string[] args)
            {
                Employee e =new Employee();
                e.Empid = 200010;
                e.Salary = 25000;
                e.Name = "vivek";
                e.Department.Deptid = 102;
                e.Department.Deptname = "QA";
                e.Department.Manager = "ROY";
                Console.WriteLine(e.Empid);
                Console.WriteLine(e.Name);
                Console.WriteLine(e.Salary);
                Console.WriteLine(e.Department.Deptname);
                Console.WriteLine(e.Department.Manager);

            }
        }

    }
}
