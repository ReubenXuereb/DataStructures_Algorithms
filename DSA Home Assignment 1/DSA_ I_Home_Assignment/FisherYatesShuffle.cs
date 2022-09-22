using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA__I_Home_Assignment
{
    /// <summary>
    /// Class representing the Fisher Yates Shuffle.
    /// Method ShuffleSequence needs to be implemented to shuffle the sequence of colour indexes 
    /// representing the Rubik Cube provided as input parameter.These must be shuffled using the 
    /// Fisher Yates Shuffle Algorithm
    /// </summary>
    class FisherYatesShuffle : Shuffle
    {
        /// <summary>
        /// Shuffles the sequence of colour indexes using a Fisher Yates Shuffle
        /// </summary>
        /// <param name="rubikCubeArray">input sequence of colour indexes representing a Rubik Cube</param>
        public void ShuffleSequence(int[] rubikCubeArray)
        {
            var random = new Random();
            for (int i = rubikCubeArray.Length - 1; i > 1; i--)
            {
                // Pick random element to swap.
                int j = random.Next(i + 1); // 0 <= j <= i-1
                // Swap.
                int tmp = rubikCubeArray[j];
                rubikCubeArray[j] = rubikCubeArray[i];
                rubikCubeArray[i] = tmp;
            }
        }
    }
}


