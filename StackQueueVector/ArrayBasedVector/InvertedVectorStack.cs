using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayBasedVector
{
    class InvertedVectorStack : iStackADT
    {

        private ArrayBasedVector stackVector;
        public InvertedVectorStack(int maxSize)
        {
            stackVector = new ArrayBasedVector(maxSize);
        }

        public int Peek()
        {
            //Get index of last element
            int topOfStack = stackVector.getSize() - 1;
            //Return the last element
            return stackVector.getElementAtRank(topOfStack);
        }

        public int Pop()
        {
            //Get index of last element
            int topOfStack = stackVector.getSize() - 1;
            //Remove and return the last element
            return stackVector.RemoveAtRank(topOfStack);
        }

            public void Push(int value)
        {
            //Calculate the next free location in the stack
            int topOfStack = stackVector.getSize();
            //Insert at the next free location
            stackVector.InsertAtRank(topOfStack, value);
        }
    }
}
