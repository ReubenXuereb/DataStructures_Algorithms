using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpiricalAnalysis_Stacks
{
    class SinglyLinkedStack<T>: StackADT<T>
    {
        //The pointer to the first node in the list,all other nodes are linked to it successively
        SinglyLinkedNode<T> Head;

        //Keeps track of the number of elements in the stack
        int size;

        //Constructor for SinglyLinkedStack
        public SinglyLinkedStack()
        {
            //empty constructor.
        }


        //Inserts an element at  the head of the stack
        public void Push(T elementValue)
        {
            //Create a new node with teh given element value
            SinglyLinkedNode<T> newNode = new SinglyLinkedNode<T>();
            newNode.Element = elementValue;

            //Check if stack is empty
            if(Head==null)
            {
                Head = newNode; //Head becomes the new node
            }
            else
            {
                //Set the new node to recognize the current head as the node just after it
                newNode.NextNode = Head;
                //Set the Head pointer to recognize the new node as the start of the list
                Head = newNode;
            }

            //Increase the size
            size++;

        }

        //Returns the element at the head of the stack
        public T Pop()
        {
            //Checkif the stack is empty
            if(size==0)
            {
                throw new InvalidOperationException("Empty Stack");
            }
            else
            {
                //Create a pointer to the current head so that you do not loose track of it
                SinglyLinkedNode<T> firstNode = Head;

                //Set the start of the list to be the node right after the current head
                Head = Head.NextNode;

                //Set the next node after the firstNode retreived earlier to null
                firstNode.NextNode = null;

                //Decrease the size of the stack
                size--;
                
                //return the element for the first node
                return firstNode.Element;
            }
        }
    }
}
