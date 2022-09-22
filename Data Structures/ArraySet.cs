using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    class ArraySet : ISetADT
    {
        private int[] numberSet; //holds fata in the set data structure
        public int[] NumberSet { get => numberSet; set => numberSet = value; }

        

        public ArraySet(int[] inputArrray)
        {
            numberSet = inputArrray;
        }
        public int Count(int element)
        {
            int result = 0;
            //For evey number in the array
            foreach(int num in numberSet)
            {
                //Check if it is equal to element
                if(num == element)
                {
                    //if yes, add 1 to result
                    result++;
                }
            }

            return result;
        }

        public ISetADT Union(ISetADT set2)
        {
            //Chanfe set2 from the ADT type into the data structure type
            ArraySet arraySet2 = (ArraySet)set2; // type casting
                                                  //Create an array to hold the union set
            int sizeOfUnion = numberSet.Length + arraySet2.NumberSet.Length;
            int[] union = new int[sizeOfUnion];

            //Copy the contents of set1 into the union set
            NumberSet.CopyTo(union, 0); // copy the contents of number aray into union array starting from index 0 in union array

            //Copy the contents of set2 into union array
            arraySet2.NumberSet.CopyTo(union, numberSet.Length); //copy the contents of set2 number set 
                                                                 //into the union array starting from the next free location
                                                                 //which is equal to the length of the first array we copied

           //Create a new set with the unioon array and return it
            ArraySet unionSet = new ArraySet(union);
            return unionSet;


        }
    }
}
