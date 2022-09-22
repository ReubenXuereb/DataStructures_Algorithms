using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayBasedVector
{
    class ArrayBasedVector : VectorADT
    {
        //Array on which the vector is based; holds all elements for the vector
        private int[] elements;
        //Keeps track if thecurrent number of elements in the vector
        private int size;
      

        public ArrayBasedVector(int maxSize)
        {
            elements = new int[maxSize];
        }
        public int getElementAtRank(int r)
        {
            //CHeck if possible to get element - vecotr not empty and rank is valid
            if(isEmpty() == false && r >= 0 && r <= size-1)
            {
                return elements[r];
            }
            else
            {
                //Console.WriteLine("Error! Empty Vector of Invalid Rank");
                throw new InvalidOperationException("Empty Vector or Invalid Rank");
            }
        }

        public int getSize()
        {
            return size;
        }

        public void InsertAtRank(int r, int value)
        {
            //Check if vector is full
            if(getSize() == elements.Length)
            {
                throw new InvalidOperationException("Vector Full.");
                
            }
            else
            {
                //CHeck if rank is valid
                if (r < 0 || r > size)
                {
                    throw new InvalidOperationException("Invalid Rank");
                }
                else
                {
                    //Loop for size-1 to r, so that I can shift backwards
                    for(int i = size-1; i>=r; i--)
                    {
                        elements[i + 1] = elements[i];
                    }

                    //Insert the new element at rank
                    elements[r] = value;

                    //Increment sizze when adding
                    size++;
                }
            }
        }

        public bool isEmpty()
        {
            if(size > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public int RemoveAtRank(int r)
        {
            throw new NotImplementedException();
            //Decrease size when you remove
            //size--;
        }

        public void replaceAtRanke(int r, int value)
        {
            //CHeck if possible to get element - vecotr not empty and rank is valid
            if (isEmpty() == false && r >= 0 && r <= size - 1)
            {
               elements[r] = value;
            }
            else
            {
                //Console.WriteLine("Error! Empty Vector of Invalid Rank");
                throw new InvalidOperationException("Empty Vector or Invalid Rank");
            }
        }
    }
}
