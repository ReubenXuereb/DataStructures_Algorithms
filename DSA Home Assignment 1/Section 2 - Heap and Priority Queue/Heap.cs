using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_2___Heap_and_Priority_Queue
{
    /// <summary>
    /// Class implementing Min Heap Data Structure
    /// </summary>
    class Heap
    {
        //Array holding the lemenets in the heap
        int[] heapElements;
        int arrSize;
        public int heapSize;
        int parentIndex;
        int temp;

        public Heap()
        {
            arrSize = 0;
            heapSize = 0;
            heapElements = new int[arrSize];
        }

        public Heap(int size)
        {
            heapElements = new int[size];

        }

     
        public void setHeapSize(int size)
        {
            this.arrSize = size;
            heapElements = new int[size];
        }

        //TODO : IMPLEMENT THE INSERT and HEAPSORT OPERATIONS FOR THE MIN HEAP DATA STRUCTURE IN THIS CLASS. 
        //THE HEAP IN QUESTION STORES INTEGERS ONLY
        public void Insert(int value)
        {

            if (heapSize == heapElements.Length)
            {
                throw new Exception("Heap is at full capacity");
            }
            else
            {
                heapElements[heapSize] = value;
                heapSize++;
                HeapifyUp(heapSize - 1);
            }
        }

        public int removeMin()
        {
            int min = heapElements[0];

            if (heapSize == 0)
            {
                throw new Exception("Heap is empty!");
            }
            else
            {
                heapElements[0] = heapElements[heapSize - 1];
                heapSize--;
                if (heapSize > 0)
                {
                    HeapifyDown(0);
                }
                return min;
            }
        }


        internal string Insert(object value)
        {
            throw new NotImplementedException();
        }

        private void HeapifyUp(int index)
        {

            if (index != 0)
            {
                parentIndex = getParentIndex(index);
                if (heapElements[parentIndex] > heapElements[index])
                {
                    temp = heapElements[parentIndex];
                    heapElements[parentIndex] = heapElements[index];
                    heapElements[index] = temp;
                    HeapifyUp(parentIndex);
                }
            }
        }

        private int getParentIndex(int index)
        {
            return (index - 1) / 2;
        }

        private int getRightChildIndex(int nodeIndex)
        {
            return (2 * nodeIndex) + 2;
        }
        private int getLeftChildIndex(int nodeIndex)
        {
            return (2 * nodeIndex) + 1;
        }

        private void HeapifyDown(int nodeIndex)
        {
            int leftChildIndex, rightChildIndex, minIndex, tmp;

            leftChildIndex = getLeftChildIndex(nodeIndex);

            rightChildIndex = getRightChildIndex(nodeIndex);

            if (rightChildIndex >= heapSize)
            {
                if (leftChildIndex >= heapSize)
                {
                    return;
                }
                else
                {
                    minIndex = leftChildIndex;
                }
            }
            else
            {
                if (heapElements[leftChildIndex] <= heapElements[rightChildIndex])
                {
                    minIndex = leftChildIndex;
                }
                else
                {
                    minIndex = rightChildIndex;
                }
            }
            if (heapElements[nodeIndex] > heapElements[minIndex])
            {
                tmp = heapElements[minIndex];

                heapElements[minIndex] = heapElements[nodeIndex];

                heapElements[nodeIndex] = tmp;

                HeapifyDown(minIndex);
            }
        }

        public void BuildMinHeap(int[] input)
        {
            if (heapSize > 0)
            {
                //clear the current heap
                Array.Resize(ref heapElements, input.Length);
                heapSize = 0;
                for (int i = 0; i < heapElements.Length; i++)
                {
                    heapElements[i] = input[i];
                    heapSize++;
                }
            }
            for (int i = heapSize - 1 / 2; i >= 0; i--)
            {
                MinHeapify(i);
            }
        }

        private void MinHeapify(int index)
        {
            int left = 2 * index;
            int right = (2 * index) + 1;
            int smallest = index;
            if (left < heapSize && heapElements[left] < heapElements[index])
            {
                smallest = left;
            }
            else
            {
                smallest = index;
            }
            if (right < heapSize && heapElements[right] < heapElements[smallest])
            {
                smallest = right;
            }
            if (smallest != index)
            {
                swap(ref heapElements, index, smallest);
                MinHeapify(smallest);
            }
        }
        private void swap(ref int[] input, int a, int b)
        {
            int temp = input[a];
            input[a] = input[b];
            input[b] = temp;
        }

    }





}

