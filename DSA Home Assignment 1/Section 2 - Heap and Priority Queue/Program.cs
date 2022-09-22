using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_2___Heap_and_Priority_Queue
{
    /// <summary>
    /// THIS CLASS CONTAINS CODE TO TEST YOUR HEAP AND HiLo PRIOIRTY QUEUE
    /// NO MORE ADDITIONS/MODIFICATIONS ARE NEEDED TO THE CODE IN THIS CLASS.
    /// YOU SHOULD SIMPLY RUN THIS CLASS TO VERIFY THAT THE DATA STRUCTURES ARE WORKING CORRECTLY
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int size = 10;

            //Creating a Prioirty Queue
            Prioirty_Queue priorityQueue = new Prioirty_Queue(size);

            //Add items in the Queue
            priorityQueue.Enque("Low", 1);
            priorityQueue.Enque("High", 6);
            priorityQueue.Enque("Low", 5);
            priorityQueue.Enque("High", 10);
            priorityQueue.Enque("Low", 2);
            priorityQueue.Enque("High", 7);
            priorityQueue.Enque("Low", 4);
            priorityQueue.Enque("High", 9);
            priorityQueue.Enque("Low", 3);
            priorityQueue.Enque("High", 8);


            //Remove items from the queue
            Console.WriteLine("\n\nServicing Items in Priority Queue : \n\n");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(priorityQueue.Service());
            }

            Console.WriteLine("\n\nPress Any Key to Exit...");
            Console.ReadKey();
        }
    }
}
