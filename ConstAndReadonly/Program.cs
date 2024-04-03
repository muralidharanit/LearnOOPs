using System;

namespace ConstAndReadonly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sample sample = new Sample(100, 200);
            Console.WriteLine("Read only value of myvar1 : {0}", sample.myvar1);

            Sample sample1 = new Sample(100);
            Console.WriteLine("Read only value of myvar1 : {0}", sample1.myvar1);

            //If try to assign value to readonly variable provides a compile time error.
            //sample.myvar1 = 10;

            // const by default its a static, to access the value, object is not required.
            int myConst = Sample.myConst;

            // to access "readonly" you need create object, or mark it as "static readonly"
            // int myReadonly = Sample.myvar1 (compile time error since declared with out static) 

            Console.WriteLine("Read only value of myConst : {0}", myConst);

            Console.ReadLine();
        }
    }

    class Sample
    {
        public readonly int myvar1 = 20;
        public readonly int myvar2;
        public static readonly int myvar3;

        //For const must needs to provide the value otherwise gives the compile time error.
        //public const int myConst; (compile time error)
        public const int myConst = 10;

        // Values of the readonly variables can change one time using constructor.
        public Sample(int a, int b)
        {
            myvar1 = a; // myvar1 default value is 20 that can be changed here.
            myvar2 = b;

            //compile time constants not possible to assign the values. 
            //myConst = 50; (compile time error)
        }

        public Sample(int a)
        {
            myvar2 = a;
        }
    }
}
