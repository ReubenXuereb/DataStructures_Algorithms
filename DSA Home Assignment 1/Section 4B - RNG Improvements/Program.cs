using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_4B___RNG_Improvements
{
    class Program
    {
        /// <summary>
        /// THIS CLASS CONTAINS CODE TO TEST YOUR IMPROVED RANDOM NUMBER GENERATOR
        /// NO MORE ADDITIONS/MODIFICATIONS ARE NEEDED TO THE CODE IN THIS CLASS.
        /// YOU SHOULD SIMPLY RUN THIS CLASS TO VERIFY THAT THE IMPROVED RNG IS WORKING CORRECTLY
        /// </summary>
        static void Main(string[] args)
        {
            ImporvedRandomNumberGenerator randomNumberGenerator = new ImporvedRandomNumberGenerator();

            //Define Parameters
            Console.Write("How Many Random Numbers Would you like to Generate : ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is the Minimum Random Number Would you like to Generate : ");
            int min = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is the Maximum Random Number Would you like to Generate : ");
            int max = Convert.ToInt32(Console.ReadLine());


            //Generate a sequence of Random Numbers between Min and a Max
            Console.WriteLine("Generating " + n + " Random Numbers between " + min + " and " + max + "\\n");
            long[] randomSequenceMinToMax = randomNumberGenerator.GenerateRandomSequence_Improved(n, min, max);
            OutputSequence(randomSequenceMinToMax);

            Console.WriteLine("\n\nPress Any Key to Exit...");
            Console.ReadKey();
        }
            /// <summary>
            /// Outputs every element in the array on screen
            /// </summary>
            /// <param name="sequence">array containing sequence of numbers</param>
            private static void OutputSequence(long[] sequence)
            {
                foreach (long num in sequence)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
