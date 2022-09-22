using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    public interface ILinkedList<T>
    {
        //Returns number of nodes in List
        int GetSize();
        
        //Returns True if List is Empty or False otherwise
        bool isEmpty();
        
        //Returns the Next Node from the given Cursor node
        Node<T> NextNode(Node<T> Cursor);
        
        //Returns the Previous Node from the given Cursor node
        Node<T> PrevNode(Node<T> Cursor);

        //Inserts a node with the given element at the Head of the List
        void InsertFirst(T Element);

        //Inserts a node with the given element after the specified cursor node
        void InsertAfter(T Element, Node<T> Cursor);

        //Inserts a node with the given element at the end of the List
        void InsertLast(T Element);

        //Removes the node at the head of the list and returns it
        Node<T> RemoveFirst();

        //Removes the node after the given cursor node and returns it
        Node<T> RemoveAfter(Node<T> Cursor);

        //Removes the node at the head of the end and returns it
        Node<T> RemoveLast();
    }
}
