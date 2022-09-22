using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace EmpiricalAnalysis_Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Time the array based stack for various problem sizes with 10,000 repetitions
            long time_100Elements_Array = timeArrayBasedStack(10000, 100);
            long time_1000Elements_Array = timeArrayBasedStack(10000, 1000);
            long time_10000Elements_Array = timeArrayBasedStack(10000, 10000);

            //Output Empirical Evidence
            Console.WriteLine("Array Based Stack: ");
            Console.WriteLine("Size : 100 \tTime : "+time_100Elements_Array);
            Console.WriteLine("Size : 1000 \tTime : " + time_1000Elements_Array);
            Console.WriteLine("Size : 10000 \tTime : " + time_10000Elements_Array);

            //Time the singly linked list based stack for various problem sizes with 10,000 repetitions
            long time_100Elements_Singly = timeSinglyLinkedListStack(10000, 100);
            long time_1000Elements_Singly = timeSinglyLinkedListStack(10000, 1000);
            long time_10000Elements_Singly = timeSinglyLinkedListStack(10000, 10000);

            //Output Empirical Evidence
            Console.WriteLine("\n\nSingly Linked List Based Stack: ");
            Console.WriteLine("Size : 100 \tTime : " + time_100Elements_Singly);
            Console.WriteLine("Size : 1000 \tTime : " + time_1000Elements_Singly);
            Console.WriteLine("Size : 10000 \tTime : " + time_10000Elements_Singly);

            Console.ReadLine();

        }


        public static long timeSinglyLinkedListStack(long repetitions, long numberOfElements)
        {
            //Total number of elapsed time for all repetitions
            long timeElapsed = 0;

            //Create a StopWatch Object to Time
            Stopwatch timer = new Stopwatch();

            for (int r = 0; r < repetitions; r++)
            {

                //Create Singly Linked List Stack 
                SinglyLinkedStack<int> singlyLinkedStack = new SinglyLinkedStack<int>();

                //Start the stopwatch
                timer.Start();

                //For the numberof elements required push elements onto the stack
                for (int i = 0; i < numberOfElements; i++)
                {
                    singlyLinkedStack.Push(i);
                }

                //Stop the timer
                timer.Stop();

                //Add the time taken for this repetition to the time already elapsed for previous repetitions           
                timeElapsed = timeElapsed + timer.ElapsedTicks;

                //Reset the timer
                timer.Reset();
            }

            //Calculate the average time for each repetition
            long averageTime = timeElapsed / repetitions;

            //Return the average time for aninsert of numberOfElements
            return averageTime;
        }

        public static long timeArrayBasedStack(long repetitions, long numberOfElements)
        {
            //Total number of elapsed time for all repetitions
            long timeElapsed = 0;

            //Create a StopWatch Object to Time
            Stopwatch timer = new Stopwatch();

            for(int r = 0; r < repetitions; r++)
            {

                //Create an Array Based Stack of the given number of elements
                ArrayBasedStack<int> arrayStack = new ArrayBasedStack<int>(numberOfElements);
            
                //Start the stopwatch
                timer.Start();

                //For the numberof elements required pop elements onto the stack
                for(int i = 0; i < numberOfElements; i++)
                {
                    arrayStack.Push(i);
                }

                //Stop the timer
                timer.Stop();

                //Add the time taken for this repetition to the time already elapsed for previous repetitions           
                timeElapsed = timeElapsed + timer.ElapsedTicks;

                //Reset the timer
                timer.Reset();
            }

            //Calculate the average time for each repetition
            long averageTime = timeElapsed / repetitions;

            //Return the average time for aninsert of numberOfElements
            return averageTime;

        }
    }
}
