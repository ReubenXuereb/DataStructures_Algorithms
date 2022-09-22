using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpiricalAnalysis_Stacks
{
    /// <summary>
    /// Structure for storing Elements working in a LIFO Order
    /// </summary>
    /// <typeparam name="T">Generic Parameter</typeparam>
    interface StackADT<T>
    {
        /// <summary>
        /// Method to add item on top of stack
        /// </summary>
        /// <param name="element">element to be added</param>
        void Push(T element);

        /// <summary>
        /// Method to remove and return element on top of stack 
        /// </summary>
        /// <returns>element on top of stack</returns>
        T Pop();
    }
}
