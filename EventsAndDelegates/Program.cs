using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class MyEventArgs : EventArgs
    {
        public int Value { get; set; }
        public MyEventArgs(int value) { Value = value; }
    }

    public class MyPublisher
    {
        public event EventHandler<MyEventArgs> MyEvent;
        public void RaiseEvent(int value)
        {
            MyEvent?.Invoke(this, new MyEventArgs(value));
        }
    }

    public class MySubscriber
    {
        public void HandleEvent(object sender, MyEventArgs e)
        {
            Console.WriteLine("Event raised with value: " + e.Value);
        }
    }


    public class Program
    {
        static void Main(string[] args)
        {
            MyPublisher publisher = new MyPublisher();
            MySubscriber subscriber = new MySubscriber();
            publisher.MyEvent += subscriber.HandleEvent;
            publisher.RaiseEvent(5); 
            // "Event raised with value: 5" is printed to the console
            Console.ReadLine();
        }
    }


    public delegate void RectangleDelegate(double Width, double Height);

    public class Rectangle
    {
        public void GetArea(double Width, double Height)
        {
            Console.WriteLine($"Area is {Width * Height}");
        }
        public void GetPerimeter(double Width, double Height)
        {
            Console.WriteLine($"Perimeter is {2 * (Width + Height)}");
        }
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            
            // add reference area method
            RectangleDelegate rectDelegate = new RectangleDelegate(rect.GetArea);
            // RectangleDelegate rectDelegate = rect.GetArea;

            // binding a method with delegate object
            // In this example rectDelegate is a multicast delegate. 
            // You use += operator to chain delegates together.

            rectDelegate += rect.GetPerimeter;

            Delegate[] InvocationList = rectDelegate.GetInvocationList();
            Console.WriteLine("InvocationList:");
            foreach (var item in InvocationList)
            {
                Console.WriteLine($"  {item}");
            }

            Console.WriteLine();
            Console.WriteLine("Invoking Multicast Delegate:");
            rectDelegate(23.45, 67.89);
            //rectDelegate.Invoke(13.45, 76.89);

            Console.WriteLine();
            Console.WriteLine("Invoking Multicast Delegate After Removing one Pipeline:");
            //Removing a method from delegate object
            rectDelegate -= rect.GetPerimeter;
            rectDelegate.Invoke(13.45, 76.89);

            

            Console.ReadKey();
        }
    }




}





//internal class Program
//{
//    static void Main(string[] args)
//    {
//        Button button = new Button();
//        User user = new User();
//        // button.Clicked += user.PerformAction;
//        button.PressButton();
//    }
//}

//public class Button
//{
//    public event EventHandler Clicked;
//    public void PressButton()
//    {
//        Clicked?.Invoke(this, EventArgs.Empty);
//    }
//}

//public class User
//{
//    public void PerformAction()
//    {
//        Console.WriteLine("Action Performed!");
//    }
//}

