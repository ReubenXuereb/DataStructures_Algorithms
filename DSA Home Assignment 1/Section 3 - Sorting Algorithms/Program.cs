using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_3___Sorting_Algorithms
{
    /// <summary>
    /// THIS CLASS CONTAINS CODE TO TEST YOUR SORTING ALGORITHMS
    /// NO MORE ADDITIONS/MODIFICATIONS ARE NEEDED TO THE CODE IN THIS CLASS.
    /// YOU SHOULD SIMPLY RUN THIS CLASS TO VERIFY THAT THE ALGORITHMS ARE WORKING CORRECTLY
    /// </summary>
    class Program
    {
        /// <summary>
        /// Random Number Generator to be used to be used within the program
        /// </summary>
        static Random randomNumberGenerator = new Random();

        static void Main(string[] args)
        {
            int n = 20;           
            int max = 100;

            //Generate an unsorted sequence of n numbers ranging from 0 to max
            int[] unsortedArray = generateRandomSequence(n, max);
           
            //Sort the sequence using Merge Sort and Output
            MergeSort mergeSortEngine = new MergeSort();
            int[] mergeSortedArray = mergeSortEngine.Sort(unsortedArray);

            Console.Write("Output for Merge Sort with {0} random numbers ranging from 0 to {1}: \n\n", n, max);
            OutputSequence(mergeSortedArray);

            //Sort the sequence using Quick Sort and Output
            QuickSort quickSortEngine = new QuickSort();
            int[] quickSortedArray = quickSortEngine.Sort(unsortedArray);

            Console.Write("\n\nOutput for Quick Sort with {0} random numbers ranging from 0 to {1}: \n\n", n, max);
            OutputSequence(quickSortedArray);

            Console.WriteLine("\n\nPress Any Key to Continue...");
            Console.ReadKey();
        }


        /// <summary>
        /// Generates a sequenece of size n unique random numbers between 0 and a maximum value 
        /// </summary>
        /// <param name="n">size of sequence</param>
        /// <param name="max">max value in range</param>
        /// <returns>sequence of random numbers of size n between 0 and max</returns>
        private static int[] generateRandomSequence(int n, int max)
        {
            int[] randomSequence = new int[n];

            int i = 0;

            do
            {
                int randomNumber = randomNumberGenerator.Next(max);
                int numberFoundAt = Array.IndexOf(randomSequence, randomNumber);
                if (numberFoundAt < 0)
                {
                    randomSequence[i] = randomNumber;
                    i++;
                }
            } while (i < n);

            return randomSequence;
        }

        /// <summary>
        /// Outputs every element in the array on screen
        /// </summary>
        /// <param name="sequence">array containing sequence of numbers</param>
        private static void OutputSequence(int[] sequence)
        {
            foreach (int num in sequence)
            {
                Console.WriteLine(num);
            }
        }
    }
}
