using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayBasedVector
{
    interface VectorADT
    {

        /// <summary>
        /// Returns the curretn number of elements stored in a vector
        /// </summary>
        /// <returns>int number of elements</returns>
        int getSize();
        /// <summary>
        /// Returns true if the vector is empty, false otherwise
        /// </summary>
        /// <returns>bool True if Empty, False Otherwise</returns>
        bool isEmpty();
        /// <summary>
        /// Returns the value of the element stored at rank r
        /// </summary>
        /// <param name="r"> in rank </param>
        /// <returns>int element at rank</returns>
        int getElementAtRank(int r);
        void replaceAtRanke(int r, int value);
        void InsertAtRank(int r, int value);
        int RemoveAtRank(int r);
    }
}
