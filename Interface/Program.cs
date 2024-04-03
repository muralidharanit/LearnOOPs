using System;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;

            ICustomer basicCustomer = new BasicCustomer();
            Console.WriteLine("Basic customer discount : {0}", basicCustomer.GetDiscount());

            ICustomer premiumCustomer = new PremiumCustomer();
            Console.WriteLine("Premium customer discount : {0}", premiumCustomer.GetDiscount());

            ICustomer eliteCustomer = new EliteCustomer();
            Console.WriteLine("Elite customer discount : {0}", eliteCustomer.GetDiscount());

            Console.ReadLine();
        }
    }

    interface ICustomer
    {
        //this is a field. this is not allowd inside the interface, gives compile time error.
        //string _myField;

        //this is a property and allowd inside the interface.
        // string myField { get; set; }
        int GetDiscount();
    }

    public class BasicCustomer : ICustomer
    {
        // No discount;
        public int GetDiscount()
        {
            return 0;
        }
    }

    public class PremiumCustomer : ICustomer
    {
        public int GetDiscount()
        {
            return 10;
        }
    }

    public class EliteCustomer : ICustomer
    {
        public int GetDiscount()
        {
            return 20;
        }
    }
}
