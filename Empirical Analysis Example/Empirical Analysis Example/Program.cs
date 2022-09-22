using System;
using System.Diagnostics;

namespace Empirical_Analysis_Example
{
    class Program
    {
        //Factorial 5! = 5x4x3x2x1 = 120
        static void Main(string[] args)
        {
            long timeTaken = 0;
            int reps = 10000;

            timeTaken = TimeFactorialIterative(10, reps);
            Console.WriteLine("Time taken for 10! Iteratively is "+timeTaken);

            timeTaken = TimeFactorialIterative(100, reps);
            Console.WriteLine("Time taken for 100! Iteratively is " + timeTaken);

            timeTaken = TimeFactorialIterative(1000, reps);
            Console.WriteLine("Time taken for 1000! Iteratively is " + timeTaken);


            Console.WriteLine("\n\n");
            timeTaken = TimeFactorialRecursive(10, reps);
            Console.WriteLine("Time taken for 10! Recursively is " + timeTaken);

            timeTaken = TimeFactorialRecursive(100, reps);
            Console.WriteLine("Time taken for 100! Recursively is " + timeTaken);

            timeTaken = TimeFactorialRecursive(1000, reps);
            Console.WriteLine("Time taken for 1000! Recursively is " + timeTaken);

            Console.ReadKey();

        }

        public static long TimeFactorialIterative(int number, int repetitions)
        {
            //1. Creating an object of Iteritive Factorial
            Iterative_Factorial iterative = new Iterative_Factorial();

            //2. Create stop watch object
            Stopwatch timer = new Stopwatch();

            for (int i = 0; i < repetitions; i++)
            {
                //3. Start the stop watch
                timer.Start();

                //4. Execute the opertation
                iterative.WorkOutFactorial(number);

                //5. Stop teh stop watch
                timer.Stop();
            }
                //6. Return time
                return timer.ElapsedTicks/repetitions;
            
                                                       
        }


        public static long TimeFactorialRecursive(int number, int repetitions)
        {
            //1. Creating an object of Recursive Factorial
            Recursivve_Factorial recursive = new Recursivve_Factorial();

            //2. Create stop watch object
            Stopwatch timer = new Stopwatch();

            for (int i = 0; i < repetitions; i++)
            {
                //3. Start the stop watch
                timer.Start();

                //4. Execute the opertation
                recursive.WorkOutFactorial(number);

                //5. Stop teh stop watch
                timer.Stop();
            }
            //6. Return time
            return timer.ElapsedTicks / repetitions;


        }
    }
}
