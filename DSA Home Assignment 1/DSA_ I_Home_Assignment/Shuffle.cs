using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA__I_Home_Assignment
{
    /// <summary>
    /// Interface defining the behaviours to be carried out by classes for Shuffling Algorithms.
    /// This interface is ready and requires no modification.
    /// </summary>
    interface Shuffle
    {
        /// <summary>
        /// Shuffles the rubikCubeArray representing a rubics cube where each number represents a colour index
        /// </summary>
        /// <param name="sequence">the rubikCubeArray of colour indexes provided to the shuffling algorithm</param>
        /// <returns>int[] an array with the shuffled rubikCubeArray</returns>
        void ShuffleSequence(int[] rubikCubeArray);
    }
}
