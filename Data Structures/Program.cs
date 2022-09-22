using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an instance of Array Set
            int[] inputArray1 = { 1, 2, 3, 4, 5, 6, 7, 1, 8, 9, 1 };
            ArraySet numberSet1 = new ArraySet(inputArray1); // --> called constructor and passed array as parm

            //Call the method count for arrayset to see how many times no 1 is in the set
            int countOfElement = numberSet1.Count(1);

            Console.WriteLine("Number of 1s int the set: " + countOfElement);

            //Create another Array Set
            int[] inputArray2 = { 10, 11, 12 };
            ArraySet numberSet2 = new ArraySet(inputArray2);

            //Call the method union to join the two sets into a new set
            ArraySet unionSet = (ArraySet) numberSet1.Union(numberSet2); //Type cast because Union returns ISetADT

            //Output the contents of the union set
            foreach(int num in unionSet.NumberSet)
            {
                Console.Write(num + " ");
            }

            Console.ReadKey();

        }
    }
}
