using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_2___Heap_and_Priority_Queue
{
    /// <summary>
    /// A class representing a priority queue that services elements according to their priority and value
    /// Utilizes two Min Heap Data structures to carry out operations
    /// </summary>
    class Prioirty_Queue
    {
        //This heaps stores all elemenst with a "Low" Priority
        Heap lowPriorityElements;
        //This heap stores all elements with a "High Priority"
        Heap highPriorityElements;


        public Prioirty_Queue(int size)
        {
            lowPriorityElements = new Heap(size);
            highPriorityElements = new Heap(size);
        }

        /// <summary>
        /// Adds a new element to the queue depending on its importance and va;ue
        /// </summary>
        /// <param name="priority">Importance of the element can be "High" or "Low"</param>
        /// <param name="elementValue">The value of the integer element</param>
        public void Enque(string priority, int elementValue)
        {

            //TODO: Implement Enque code here to complete Section 2 
            //NOTE THAT HIGH PRIORITY ELEMENTS AND LOW PRIORITY ELEMENTS NEED TO BE SAVED IN DIFFERENT HEAPS

           if(priority == "High")
            {
              highPriorityElements.Insert(elementValue);
            }

           if(priority == "Low")
            {
                lowPriorityElements.Insert(elementValue);
            }


        }

        /// <summary>
        /// Sevices one element in the Priority Queue based on the priority and value
        /// High Priority elements are serviced before Low Priority Elements
        /// Elements with the same priority are serviced based on their value 
        /// The element having the smallest value is serviced first
        /// </summary>
        public int Service()
        {
            //TODO: Implement Service code here to complete Section 2
            //NOTE THAT HIGH PRIORITY ELEMENTS ARE SERVICED BEFORE LOW PRIORITY ELEMENTS
            //ELEMENTS WITH THE SAME PRIORITY SHOULD BE SERVICED ACCORDING TO THEIR VALUE SMALLEST FIRST
            //ELEMENTS SERVICED ARE TO BE ADDED TO THE LIST OF ELEMENTS SERVICED ACCORDING TO THE ORDER IN WHICH THEY ARE SERVICED
            
            //Remove NotImplementedException and replace with code for Seervicing Elements
            if(highPriorityElements.heapSize != 0)
            {
                return highPriorityElements.removeMin();
            }
            else
            {
                return lowPriorityElements.removeMin();
            }
            

        }
    }
}
