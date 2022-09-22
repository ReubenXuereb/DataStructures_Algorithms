using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpiricalAnalysisFactorial
{
    class Program
    {
        static long FactorialIterative(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("n must be 0 or greater!", "n");
            }

            long result = 1;
            //for (int i = 2; i <= n; i++)
            for (int i = n; i > 1; i--)
            {
                result = result * i;
            }

            return result;
        }

        static long FactorialRecursive(int n)
        {
            // stopping condition
            if ((n==0) || (n == 1))
            {
                return 1;
            }

            // validation
            if (n < 0)
            {
                throw new ArgumentException("n must be 0 or greater!", "n");
            }

            return n * FactorialIterative(n - 1);
        }


        static void Main(string[] args)
        {
            FactorialIterative(5);
            FactorialRecursive(5);
            
            int runs = 10000;

            string[] output = EmpiricalAnalysis(runs, 5);
            WriteToConsole(output);

            output = EmpiricalAnalysis(runs, 10);
            WriteToConsole(output);

            output = EmpiricalAnalysis(runs, 20);
            WriteToConsole(output);

            Console.ReadKey();
        }


        private static string[] EmpiricalAnalysis(int runs, int n)
        {
            Stopwatch s = new Stopwatch();

            List<string> results = new List<string>();

            for (int i = 0; i < runs; i++)
            {
                s.Start();

                FactorialIterative(n);

                s.Stop();
            }

            results.Add(
                string.Format(
                    "Running the Iterative method for n = {0}, {1} times average time took {2} ticks", 
                    n, runs, (double)s.ElapsedTicks / (double)runs));

            s = new Stopwatch();

            for (int i = 0; i < runs; i++)
            {
                s.Start();

                FactorialRecursive(n);

                s.Stop();
            }


            results.Add(
                string.Format(
                    "Running the Recursive method for n = {0}, {1} times average time took {2} ticks",
                    n, runs, (double)s.ElapsedTicks / (double)runs));


            return results.ToArray();
        }

        private static void WriteToConsole(string[] output)
        {
            foreach (string getOutput in output)
            {
                Console.WriteLine(getOutput);
            }
        }
    }
}
