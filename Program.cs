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

            // working with doubles
            double m = 19;
            double n = 23;
            double p = 8;
            double r = (m + n) / p;
            Console.WriteLine($"Doubles addition and divison: {r}");

            // doubles and MIN and MAX
            double max = double.MaxValue;
            double min = double.MinValue;
            Console.WriteLine($"The range of double is {min} to {max}");

            // rounding
            double third = 1.0 / 3.0;
            Console.WriteLine(third);

            // DECIMAL type is more precise than a double type but has a smaller range
            decimal minDecimal = decimal.MinValue;
            decimal maxDecimal = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {minDecimal} to {maxDecimal}");

            // more accurate rounding
            // The M suffix is how you indicate that a constant should use the decimal type. 
            // Otherwise, the compiler assumes the double type.
            decimal s = 1.0M;
            decimal t = 3.0M;
            Console.WriteLine($"rounding with decimals: {s / t}");   
        }

        static void IfElseBranches() 
        {
            int a = 5;
            int b = 3;
            if (a + b > 10)
                {
                    Console.WriteLine("The answer is greater than 10");
                }
            else
                {
                    Console.WriteLine("The answer is not greater than 10");
                }  
        }

        static void ForLoops() 
        {
          for (int index = 0; index < 10; index++)
            {
                Console.WriteLine($"Hello World! The index is {index}");
            }
        }

        static void NestedLoops()
        {
          for (int row = 1; row < 5; row++)
          {
              for (char column = 'a'; column < 'e'; column++)
              {
                  Console.WriteLine($"The cell is ({row}, {column})");
              }
          }
        }

         static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // Console.WriteLine("The current time is " + DateTime.Now); 
            // WorkingWithIntegers();
            // OrderPrecedence();
            // IfElseBranches();
            // ForLoops();
            NestedLoops();
        }
    }
}
