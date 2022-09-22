using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_4___Random_Number_Generators
{
    /// <summary>
    /// Class that implements methods to generate random numbers
    /// using the Subtractive Lagged Fibonacci Algorithm
    /// 
    /// NOTE : YOU MUST IMPLEMENT ALL METHODS IN THIS CLASS TO COMPLETE SECTION 4
    /// </summary>
    public class SubtractiveLaggedFibonaci
    {
        private int j = 31;
        private int k = 63;
        private double m = 2^32;
        private int n = 0;
        private long[] initialSetOfKStates = null;

        public SubtractiveLaggedFibonaci()
        {
            n = k;
            initialSetOfKStates = new long[k];

            Random inBuiltRNG = new Random();

            for (int i = 0; i < initialSetOfKStates.Length - 1; i++)
            {
                initialSetOfKStates[i] = inBuiltRNG.Next();
            }
            

            //TODO : Populate array initialSetOfKStates with random numbers using the in-built Random object in C#

        }

        /// <summary>
        ///  Generate a single random number based on
        /// the Subtractive Lagged Fibionaci RNG algorithm
        /// </summary>
        /// <param name="min">smallest rand number that can be returned</param>
        /// <param name="max">largest random number taht can be returned</param>
        /// <returns>long randomNumber between min and max</returns>
        public long generateRandomNumber(int min, int max)
        {
            long randomNum = 0;

            if(j <= 1)
            {
                j = 31;
            }

            else
            {
                j--;
            }

            if(k <= 1)
            {
                k = 63;
            }

            else
            {
                k--;
            }

            long a = initialSetOfKStates[n - j];
            long b = initialSetOfKStates[n - k];

            randomNum = (long)(Math.Abs(a - b) % m);
            initialSetOfKStates[n - k] = (int)randomNum;
            randomNum = min + randomNum % (max + 1 - min);

            return randomNum;

            
        }
    }
}
