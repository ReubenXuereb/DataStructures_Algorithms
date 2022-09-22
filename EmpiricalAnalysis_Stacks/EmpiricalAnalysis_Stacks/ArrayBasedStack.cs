using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpiricalAnalysis_Stacks
{
    /// <summary>
    /// Class using Arrays to implement a stack according to StackADT
    /// </summary>
    /// <typeparam name="T">Generic Data type of Stack</typeparam>
    class ArrayBasedStack<T> : StackADT<T>
    {
        //Array holding the elelments in the stack
        private T[] StackElements;

        //Int holding the rank of the element currently at the top of the stack
        private int currentTopOfStack = 0;

        //Constructor to create an array  based stackof a given size
        public ArrayBasedStack(long size)
        {
            StackElements = new T[size];
        }


        public void Push(T newElement)
        {
            //Check that the Stackis not full
            if(currentTopOfStack == StackElements.Length)
            {
                throw new IndexOutOfRangeException("Stack is Full.");
            }
            else
            {
                //Input New Element at Current Top of Stack 
                StackElements[currentTopOfStack] = newElement;

                //Move top of stack to next available location
                currentTopOfStack++;
            }
        }

        public T Pop()
        {
            //Check that stack is not empty
            if(currentTopOfStack<0)
            {
                throw new InvalidOperationException("Empty Stack.");
            }
            else
            {
                //Get the element at the current top of the stack
                T topElement = StackElements[currentTopOfStack-1];
                //Setthe current top of stack to the element before the current top
                currentTopOfStack--;
                //return the top element
                return topElement;
            }
        }
    }
}
