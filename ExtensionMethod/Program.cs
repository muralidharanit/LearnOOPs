using System;

namespace ExtensionMethod
{
    public class Math
    {
        public int Add(int val1, int val2)
        {
            return val1 + val2;
        }

        public int Subtract(int val1, int val2)
        {
            return val1 - val2;
        }
    }

    public static class MathExtension
    {
        public static int Multiply(this Math math, int val1, int val2)
        {
            return val1 * val2;
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Employee GetEmployee(int id)
        {
            return new Employee { Id = id, Name = "Test" };
        }
    }

    public static class EmployeeExtension
    {
        public static Employee GetEmployee(this Employee employee, string name)
        {
            return new Employee { Id = 0, Name = "Test 123" }; ;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            
            Console.WriteLine(math.Add(5, 4));
            Console.WriteLine(math.Multiply(5, 4));
        }
    }
}
