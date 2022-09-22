using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Section_4___Random_Number_Generators;

namespace Section_4B___RNG_Improvements
{
    class ImporvedRandomNumberGenerator
    {
        //An instance of the Subtractive Lagged Fibonaci Random Number Generator developed for Section 4A
        private SubtractiveLaggedFibonaci RNG = new SubtractiveLaggedFibonaci();

        //An instance of the in-built C# Random Number Generator; use this if the Subtractive Lagged Fibonaci RNG was not implemented correctly.
        //private Random RNG = new Random();

        /// <summary>
        /// Generate a sequence of random numbers using the existing RNG instanciated above 
        /// and improve the RNG by implementing one of the improvements discussed in Section 4 Task 2
        /// 
        /// /// NOTE : THIS METHOD NEEDS TO BE IMPLEMENTED
        /// 
        /// </summary>
        /// <param name="n">size of random number sequence</param>
        /// <param name="min">minimum value in range for random numbers</param>
        /// <param name="max">maximum value in range for random numbers</param>
        /// <returns>sequence of random numbers imporved using 1 of the techniques mentioned above.</returns>
        public long[] GenerateRandomSequence_Improved(int n, int min, int max)
        {
            long[] randomSequence = new long[n];

            //Generate a sequence of n random numbers between min and max using the existing RNG
            for(int i = 0; i <n; i++)
            {
                randomSequence[i] = RNG.generateRandomNumber(min, max);
            }

            //TODO : Modify this method and write code to imporove the generation of 
            //random numbers using one of the strategies discussed in Section 4 Task 2.

            return randomSequence;

        }
    }
}
