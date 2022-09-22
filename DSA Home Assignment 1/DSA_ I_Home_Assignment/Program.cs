using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DSA__I_Home_Assignment
{  
    /****
    * SAMPLE CODE
    * THIS CODE IS INTENDED TO SHOW YOU HOW SOME OF THE READY CODED METHODS
    * PROVIDED BY YOUR LECTURER WORK. YOU ARE TO MODIFY THIS CODE TO COMPLETE SECTION 1 
    * AS DESCRIBED IN YOUR ASSIGNMENT.
    ****/
    class Program
    {
        //Size of Rubik Cube to be shuffled - the value indicates a 2x2 cube
        private static int rubikCubeSize = 2; 
        
        static void Main(string[] args)
        {
            //The code in this region is aimed at helping you test your algorithm,
            //You do not need to modify it
            //Comment it out, once you are sure that both algorithms work.
            #region testAlgorithm
            
            //Generate a Rubik Cube array for a Rubik Cube of Size rubikCubeSize x rubikCubeSize
            int[] rubikCube = generateRubikCubeArray(rubikCubeSize);
            Console.WriteLine("\n\nDISPLAYING A RUBIK CUBE OF SIZE " + rubikCubeSize + " x " + rubikCubeSize + " IN ITS UNSHUFFLED STATE\n");
            OutputSequence(rubikCube, rubikCubeSize);
            
            Console.ReadKey();

            //Make a copy of the rubik cube
            int[] rubikCubeCopy = new int[rubikCube.Length];
            rubikCube.CopyTo(rubikCubeCopy, 0);
            
            //Shuffle the copy of the rubik cube array using the Fisher Yates shuffle and output the shuffled rubikCube
            FisherYatesShuffle FYShuffle = new FisherYatesShuffle();
            FYShuffle.ShuffleSequence(rubikCubeCopy);
            Console.WriteLine("\n\nUSING FISHER YATES SHUFFLE TO SHUFFLE A RUBIK CUBE OF SIZE " + rubikCubeSize + " x " + rubikCubeSize);
            OutputSequence(rubikCubeCopy, rubikCubeSize);

            //Reset the copy of the rubik cube to its original state (not shuffled)
            rubikCube.CopyTo(rubikCubeCopy, 0);

            //Shuffle the array using the Riffle shuffle and output the shuffled rubikCube
            RiffleShuffle riffleShuffle = new RiffleShuffle();
            riffleShuffle.ShuffleSequence(rubikCubeCopy);
            Console.WriteLine("\n\nUSING 7-TIME RIFFLE SHUFFLE TO SHUFFLE A RUBIK CUBE OF SIZE " + rubikCubeSize + " x " + rubikCubeSize);
            OutputSequence(rubikCubeCopy, rubikCubeSize);
            
            Console.WriteLine("\n\nPRESS ANY KEY TO CONTINUE ");

            long TimeTaken = TimeShufflingAlgorithm(new FisherYatesShuffle(), 2, 1000);
            Console.WriteLine("Time taken to Fisher-Yates Shuffle a 2 x 2 Rubik Cube : " + TimeTaken);
            TimeTaken = TimeShufflingAlgorithm(new FisherYatesShuffle(), 5, 1000);
            Console.WriteLine("Time taken to Fisher-Yates Shuffle a 5 x 5 Rubik Cube : " + TimeTaken);
            TimeTaken = TimeShufflingAlgorithm(new FisherYatesShuffle(), 10, 1000);
            Console.WriteLine("Time taken to Fisher-Yates Shuffle a 10 x 10 Rubik Cube : " + TimeTaken);
            TimeTaken = TimeShufflingAlgorithm(new FisherYatesShuffle(), 20, 1000);
            Console.WriteLine("Time taken to Fisher-Yates Shuffle a 20 x 20 Rubik Cube : " + TimeTaken);
            TimeTaken= TimeShufflingAlgorithm(new FisherYatesShuffle(), 40, 1000);
            Console.WriteLine("Time taken to Fisher-Yates Shuffle a 40 x 40 Rubik Cube : " + TimeTaken);
            TimeTaken = TimeShufflingAlgorithm(new FisherYatesShuffle(), 80, 1000);
            Console.WriteLine("Time taken to Fisher-Yates Shuffle a 80 x 80 Rubik Cube : " + TimeTaken);






            long TimeTaken2 = TimeShufflingAlgorithm(new RiffleShuffle(), 2, 1000);
            Console.WriteLine("\n\nTime taken to Riffle Shuffle a 2 x 2 Rubik Cube : " + TimeTaken2);
            TimeTaken2 = TimeShufflingAlgorithm(new RiffleShuffle(), 5, 1000);
            Console.WriteLine("Time taken to Riffle Shuffle a 5 x 5 Rubik Cube : " + TimeTaken2);
            TimeTaken2 = TimeShufflingAlgorithm(new RiffleShuffle(), 10, 1000);
            Console.WriteLine("Time taken to Riffle Shuffle a 10 x 10 Rubik Cube : " + TimeTaken2);
            TimeTaken2 = TimeShufflingAlgorithm(new RiffleShuffle(), 20, 1000);
            Console.WriteLine("Time taken to Riffle Shuffle a 20 x 20 Rubik Cube : " + TimeTaken2);
            TimeTaken2 = TimeShufflingAlgorithm(new RiffleShuffle(), 40, 1000);
            Console.WriteLine("Time taken to Riffle Shuffle a 40 x 40 Rubik Cube : " + TimeTaken2);
            TimeTaken2 = TimeShufflingAlgorithm(new RiffleShuffle(), 80, 1000);
            Console.WriteLine("Time taken to Riffle Shuffle a 80 x 80 Rubik Cube : " + TimeTaken2);
           

            Console.ReadKey();
            #endregion


            #region timeAlgorithm
            //ToDo: Add code to Time the Shuffling Algorithms as requested, 
            //the line below helps you to understand how the TimeShufflingAlgorithm method
            //can be called to time the selected algorithm ( in this case a Fisher-Yates Shuffle) for a rubikCube of size 2  X 2 
            //over 1,000 repetitions to remove bias.
           /* long TimeTaken = TimeShufflingAlgorithm(new FisherYatesShuffle(), 2, 1000);
            Console.WriteLine("Time taken to Shuffle a 2 x 2 Rubik Cube : " + TimeTaken);
            long TimeTaken2 = TimeShufflingAlgorithm(new RiffleShuffle(), 2, 1000);
            Console.WriteLine("Time taken to Shuffle a 2 x 2 Rubik Cube : " + TimeTaken2);*/

            #endregion
        }



        #region TimingMethods
        /// <summary>
        /// Method that tests how long a shuffling algorith takes to shuffle a rubikCube of colour indexes stored in an array
        /// The ribik cube is represented by 6 faces each one having n X n squares
        /// The average time of a number of repetitions is taken to remove bias
        /// </summary>
        /// <param name="selectedAlgorithm">The Shuffling Algorithm selected</param>
        /// <param name="n"> The size of the rubikCube to be shuffled</param>
        /// <param name="repetitions">the number of repetitions to remove bias</param>
        /// <returns>long the average time elapsed to perform the shuffle</returns>
        private static long TimeShufflingAlgorithm(Shuffle selectedAlgorithm, int n, int repetitions)
        {
            //ToDo: Modify and Extend the code in this method to time the algorithm.
            Stopwatch timer = new Stopwatch();

            for (int i = 0; i < repetitions; i++)
            {
                timer.Start();
                //generate a new rubikCube from 1 to n in an array
                int[] rubikCube = generateRubikCubeArray(n);
                //Shuffle the rubikCube using the selected algorithm
                selectedAlgorithm.ShuffleSequence(rubikCube);

                timer.Stop();
            }

            return timer.ElapsedTicks/repetitions;
        }

        #endregion


        //This region contains some methods used to test the algorithms
        //You do not need to modify these methods but you may use them if you need
        #region RubikCubeManagementMethods
        
         //Enum representing the colours in the rubic cube and their indexes
        public enum RubikCubeColours { Yellow=1, Red=2, Green=3, Blue=4, White=5, Orange=6 }

        /// <summary>
        /// Generates a Rubik Cube Array for a rubik cube of Size n X n; 
        /// if n = 2, then the array for a 2 x 2 rubik cube is created
        /// and filled with colour indexes to produce an unshuffled rubik cube
        /// </summary>​
        /// <param name="n">size of each face of the rubik cube</param>​
        /// <returns>int[] representing the rubic cube with all squares on each face having the same colour</returns>​
        private static int[] generateRubikCubeArray(int n)
        {
            //Create an array capable of holding all the squares on 6 sides of an n x n Rubik Cube 
            int numberOfSquaresOnOneFace = n * n;
            int totalSquaresOnCube = numberOfSquaresOnOneFace * 6;

            int[] rubikCube = new int[totalSquaresOnCube];
            int squareIndex = 0;

            //Set the rubik cube so that each face has all its squares in the same colour 
            for (int faces = 1; faces <= 6; faces++)
            {
                for(int squaresOnFace = 0; squaresOnFace < numberOfSquaresOnOneFace; squaresOnFace++)
                {
                    rubikCube[squareIndex] = faces;
                    squareIndex++;
                }
            }
            return rubikCube;
        }

        /// <summary>
        /// Outputs every element in the rubik cube array on screen
        /// The colour index is converted to the proper colour name in the enum
        /// </summary>
        /// <param name="rubikCube">array containing rubikCube of numbers</param>
        /// <param name="sizeOfRubikCube">the size of the rubik cube i.e. if it is 2 x 2, etc.</param>>
        private static void OutputSequence(int[] rubikCube, int sizeOfRubikCube)
        {

            int squareIndex = 0;

            for (int faces = 1; faces <= 6; faces++)
            {
                Console.Write("FACE " + faces + " : ");
                for (int squaresOnFace = 0; squaresOnFace < (sizeOfRubikCube * sizeOfRubikCube); squaresOnFace++)
                {
                    Console.Write((RubikCubeColours)rubikCube[squareIndex] + "\t");
                    squareIndex++;
                }
                Console.Write("\n");
            }
        }
        #endregion
    }
}
    
    

