﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee();
            //Console.WriteLine("Base Employee GetLeaves : {0}", employee.GetLeaves());

            Employee fullTimeEmployee = new FullTimeEmployee();
            Console.WriteLine("Full time Employee GetLeaves : {0}", fullTimeEmployee.GetLeaves());

            Employee partTimeEmployee = new PartTimeEmployee();
            Console.WriteLine("Part time Employee GetLeaves : {0}", partTimeEmployee.GetLeaves());

            Console.ReadLine();
        }
    }

    public abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }

        // Leaves are not applicable to Internship Employees.
        // It is not compulsory to implement them in the derived class.
        public virtual int GetLeaves()
        {
            Console.WriteLine("I am Employee class GetLeaves");
            return 5;
        }

        // Salary must be paid to all employees, including interns,
        // so it should be compulsory to implement it in the derived class.
        public abstract int GetSalary();       
    }

    public class FullTimeEmployee : Employee
    {
        public override int GetLeaves()
        {
            return 10;
        }

        public override int GetSalary()
        {
            throw new NotImplementedException();
        }
    }

    public class PartTimeEmployee : Employee
    {
        public override int GetLeaves()
        {
            return 7;
            //return base.GetLeaves();
        }

        public override int GetSalary()
        {
            throw new NotImplementedException();
        }
    }

    public class Inters : Employee
    {
        public override int GetSalary()
        {
            throw new NotImplementedException();
        }
    }
}
