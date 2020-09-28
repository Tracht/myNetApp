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

        static void OrderPrecedence()
        {
            int a = 5;
            int b = 4;
            int c = 2;
            int d = a + b * c;
            Console.WriteLine(d);

            d = (a + b) * c;
            Console.WriteLine(d);

            d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            Console.WriteLine(d);

            int e = 7;
            int f = 4;
            int g = 3;
            int h = (e  + f) / g;
            Console.WriteLine(h);

            // quotient
            int j = (a + b) / c;
            // remainder
            int k = (a + b) % c;

            Console.WriteLine($"The quotient of (5 + 4) / 2 is ....");
            Console.WriteLine($"quotient: {j}");
            Console.WriteLine($"The remainder of (5 + 4) / 2 = is ...");
            Console.WriteLine($"remainder: {k}");
        }


         static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // Console.WriteLine("The current time is " + DateTime.Now); 
            WorkingWithIntegers();
            OrderPrecedence();
        }
    }
}
