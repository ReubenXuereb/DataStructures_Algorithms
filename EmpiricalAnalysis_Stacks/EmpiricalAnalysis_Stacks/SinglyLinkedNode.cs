using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpiricalAnalysis_Stacks
{
    /// <summary>
    /// Node object to be used in conjunction with singly linked lists
    /// </summary>
    class SinglyLinkedNode<T>
    {
        //Data part of the node
        public T Element { get; set;}

        //Pointer to next node
        public SinglyLinkedNode<T> NextNode { get; set;}
    }
}
