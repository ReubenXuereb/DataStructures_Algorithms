using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA__I_Home_Assignment
{
    /// <summary>
    /// Class representing the 7 - Time Riffle Shuffle.
    /// Method ShuffleSequence needs to be implemented to shuffle the rubikCubeArray of colour indexes 
    /// representing the Rubik Cube provided as input parameter.These must be shuffled using the using 
    /// 7- Time Riffle Shuffle Algorithm
    class RiffleShuffle : Shuffle
    {
        /// <summary>
        /// Shuffles the sequence of colour indexes using a 7-Time Riffle Shuffle
        /// </summary>
        /// <param name="rubikCubeArray">input sequence of colour indexes representing a Rubik Cube</param>
        public void ShuffleSequence(int[] rubikCubeArray)
        {
            int[] riffleArray = new int[rubikCubeArray.Length];
            int divided = rubikCubeArray.Length / 2;
            int j = riffleArray.Length - 1;
            

            /*for (int i = 0; i > 7; i--)
            {
                int c= 0;
                for (int j = 0; j < divided; j++)
                {
                    riffleArray[c] = rubikCubeArray[j];
                    c++;
                    riffleArray[c] = rubikCubeArray[divided + j];
                    c++;
                }

                for(int x = 0; x < rubikCubeArray.Length -1; x++)
                {
                    rubikCubeArray[x] = riffleArray[x];
                }
            }*/

           /* while(divided > 0)
            {
                int temp = riffleArray[divided];
                riffleArray[divided--] = riffleArray[j];
                riffleArray[j--] = temp;
            }*/




        }
    }
}
