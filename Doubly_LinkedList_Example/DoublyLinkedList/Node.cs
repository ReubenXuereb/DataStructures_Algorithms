using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    /// <summary>
    /// Node classto be used with doubly linked list having 2 pointers
    /// One for previous node and Onde for Next Node
    /// </summary>
    /// <typeparam name="T">Generics - can be any data type</typeparam>
    public class Node<T>
    {
        //Part of the node holding the data
        public T element { get; set; }
        //Pointer to the next nodein the list
        public Node<T> Next { get; set; }
        //Pointer to the previous node in the list
        public Node<T> Previous { get; set; }
    }
}
