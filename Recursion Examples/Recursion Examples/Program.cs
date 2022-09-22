using System;

namespace Recursion_Examples
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int fibonacciAns = Fibonacci(number);
            Console.WriteLine("The Value of the Fibbonacci Sequence for " +number+ " is " + fibonacciAns);

            Console.WriteLine("Enter a number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int factorialAns = Factorial(number2);
            Console.WriteLine("The value of the Factorial Sequence for " + number2 + " is " + factorialAns);
            
        }

        static int Fibonacci(int n)
        {
            //Base Case
            if(n == 1)
            {
                return 1;
            }

            //Recursive Call
            return n + Fibonacci(n - 1);
        }

        static int Factorial(int n)
        {
            //Base Case
            if(n == 1)
            {
                return 1;
            }

            //Recursive Call
            return n * Factorial(n - 1);
        }


        //Couldn't figure it out

      /*  static int Variation(int n, int k)
        {
            //Base Case
            if(n == 3) 
            {
                return 3; 
            }

            return n 

            if(k ==1)
            {
                return 1;
            }

            
        }*/

    }
}
