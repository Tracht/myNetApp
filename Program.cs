using System;

namespace myNetApp
{
    class Program
    {

        static void WorkingWithIntegers()
        {
            int a = 18; 
            int b = 6;

            // addition
            int c = a - b;
            Console.WriteLine(c);

            // subtraction
            c = a * b; 
            Console.WriteLine(c);

            // division 
            c = a / b; 
            Console.WriteLine(c);
        }

         static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // Console.WriteLine("The current time is " + DateTime.Now); 
            WorkingWithIntegers();
        }
    }
}
