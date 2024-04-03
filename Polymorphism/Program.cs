using System;
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
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            // Not possible to create a instance for abstract Employee class.
            // Employee employee = new Employee();
            // Console.WriteLine("Base Employee GetLeaves : {0}", employee.GetLeaves());



            Employee fullTimeEmployee = new FullTimeEmployee();
            Console.WriteLine("Full time Employee GetLeaves : {0}", fullTimeEmployee.GetLeaves());

            Employee partTimeEmployee = new PartTimeEmployee();
            Console.WriteLine("Part time Employee GetLeaves : {0}", partTimeEmployee.GetLeaves());

            Employee intershipEmployee = new IntershipEmployee();
            Console.WriteLine("Intership Employee GetLeaves : {0}", intershipEmployee.GetLeaves());

            Console.ReadLine();
        }
    }

    // empty abstract class 
    public abstract class Employee1
    {
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

    public class IntershipEmployee : Employee
    {
        public override int GetSalary()
        {
            return 3;
        }
    }
}
