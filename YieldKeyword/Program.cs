using System;
using System.Collections.Generic;

namespace YieldKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Get the Even numbers using list ");
            GetEvenNumbersUsingList(50);

            Console.WriteLine();
            Console.WriteLine("===================================");
            Console.WriteLine("===================================");
            Console.WriteLine();

            Console.WriteLine("Get the Even numbers using yield ");
            // If you call like this nothing will print since iterator not used.
            GetEvenNumbersUsingYield(50);

            //iterator used this method prints.
            foreach (int k in GetEvenNumbersUsingYield(50))
            {
                Console.WriteLine(k);
            }

            Console.WriteLine("Execution completed.");
            Console.ReadLine();
        }

        static IEnumerable<int> GetEvenNumbersUsingList(int limit)
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < limit; i += 2)
            {
                numbers.Add(i);
                Console.WriteLine("Print");
            }
            return numbers;
        }

        static IEnumerable<int> GetEvenNumbersUsingYield(int limit)
        {
            for (int i = 0; i < limit; i += 2)
            {
                yield return i;
                Console.WriteLine("Print");
            }
        }
    }
}
