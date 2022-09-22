using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    /// <summary>
    /// Data Structure to build doubly linked list with 
    /// data elements of any kind using generics
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class DoublyLinkedList<T> : ILinkedList<T>
    {
        //Determines the number of nodes in the list
        private int size;

        //Identifies the first node in the list
        public Node<T> Head;

        /// <summary>
        /// Returns the number of nodes in the list
        /// </summary>
        /// <returns>int size</returns>
        public int GetSize()
        {
            return size;
        }

        /// <summary>
        /// Returns true if list is empty 
        /// i.e. if Head is Null and Size 0
        /// </summary>
        /// <returns>True if empty, false otherwise</returns>
        public bool isEmpty()
        {
            if(Head ==null && size == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Node<T> NextNode(Node<T> Cursor)
        {
            //Check if there is a next Node i.e. 
            //the list is not empty and Cursor is not the last node
            if(isEmpty()==true || Cursor.Next==null)
            {
                throw new InvalidOperationException("No Next Node Available");
            }

            //return the next node after the cursor
            return Cursor.Next;
        }

        public Node<T> PrevNode(Node<T> Cursor)
        {
            //Check if there is a Previous Node i.e. the list is not empty and cursor is not the first node
            if (isEmpty() == true || Cursor.Previous==null)
            {
                throw new InvalidOperationException("No Previous Node Available");
            }

            //return the previous node before the cursor
            return Cursor.Previous;
        }

        public void InsertFirst(T Element)
        {
            //Create a new Node with data element
            Node<T> newNode = new Node<T>();
            newNode.element = Element;

            //If the list is empty, new node becomes the head
            if(isEmpty()==true)
            {
                Head = newNode;
            }
            else
            {
                //Set the new node to point to the head as its next node
                newNode.Next = Head;
                //Set the Head to point to the new node as its previous node
                Head.Previous = newNode;
                //Update the Head Pointer to point to the new node
                Head = newNode;
            }

            //Increase size by 1
            size++;
        }

        public void InsertAfter(T Element, Node<T> Cursor)
        {
            //If the list is empty, there is no nodes after which to insert
            if(isEmpty()==true)
            {
                throw new InvalidOperationException("No Nodes in List. Cannot Insert After Null");
            }

            //Create a new Node with data element
            Node<T> newNode = new Node<T>();
            newNode.element = Element;

            //If Cursor is last node in List
            if(Cursor.Next ==null)
            {
                //Set Cursor's next to point to the new node
                Cursor.Next = newNode;
                //Set New Node's Previous to point to cursor
                newNode.Previous = Cursor;
            }
           else //If Cursor has a node after it
            {
                //Create a pointer to the node right after the cursor
                Node<T> cursorNext = Cursor.Next;

                //Set the new node and the cursor node to point to eachother
                cursorNext.Previous = newNode;
                newNode.Next = cursorNext;

                //Set the new node and the cursor to recognize eachother
                newNode.Previous = Cursor;
                Cursor.Next = newNode;
            }
            //Increase size by 1
            size++;
        }

        public void InsertLast(T Element)
        {
            //Create a new node
            Node<T> newNode = new Node<T>();
            newNode.element = Element;

            //If the list is empty, new node is inserted and is also the head
            if (isEmpty() == true)
            {
                Head = newNode;
            }
            else
            {
                //Look for the last node - has Next Pointer equal to null
                //Start looking from the start of the list
                Node<T> lastNode = Head;

                //While the node we are looking at is not the last one
                while (lastNode.Next != null)
                {
                    //Move to the next node
                    lastNode = lastNode.Next;
                }//Once this loop is over, last node is struly equal to the last node in the list

                //Set the last node next pointer so that it points to the new node
                //i.e. It recognizes the new node as a node just after it
                lastNode.Next = newNode;

                //Set the new node prev pointer to the last Node so that it recognizes it as 
                //the node just before it
                newNode.Previous = lastNode;
            }
            //Increment size
            size++;
        }

        public void InsertBefore(T Element, Node<T> Cursor)
        {
            //Check if the list is empty
            if(size ==0)
            {
                throw new InvalidOperationException("Empty List.  Cannot Insert Before Node");
            }
            else
            {
                //Create a new node
                Node<T> newNode = new Node<T>();
                newNode.element = Element;

                //Check if cursor is head
                if(Cursor==Head)
                {
                    //Link the new node to the head
                    newNode.Next = Head;
                    Head.Previous = newNode;
                    //Make the new node the head
                    Head = newNode;
                }
                else
                {
                    //Link the new node to recognize the cursor as the node after it
                    newNode.Next = Cursor;
                    //Link the new node to recognize the node before the cursor as the node before it
                    newNode.Previous = Cursor.Previous;

                    //Update the node before the cursor to recognize the new node as the node after it
                    Cursor.Previous.Next = newNode;
                    //Update the cursor to recognize the the new node as the node before it
                    Cursor.Previous = newNode;
                }

                //Increase size
                size++;
            }
        }

        public Node<T> RemoveFirst()
        {

            //Check if list is empty - if Yes no Nodes to remove
            if (isEmpty() == true)
            {
                throw new InvalidOperationException("Empty List No Nodes to Remove");
            }
            else
            {
                //Create a Pointer to the node being removed i.e. the Head 
                Node<T> firstNode = Head;

                //If only 1 node in list
                if (GetSize() == 1)
                {
                    //Head should Point To Null as there are no other nodes
                    Head = null;
                }
                else
                {
                    //Set the node after the head to lose the link betwenn itself and the old head
                    Node<T> HeadNext = Head.Next;
                    HeadNext.Previous = null;

                    //Remove the link between the first node and its next node
                    Head.Next = null;

                    //Set the Node after the original head of the list to be the new head
                    Head = HeadNext;
                }

                //Decrease the Size
                size--;

                //Return the node taht was at the start of the list
                return firstNode;
            }
           
        }

        public Node<T> RemoveAfter(Node<T> Cursor)
        {
            //Check if the list is empty
            if(size ==0)
            {
                throw new InvalidOperationException("Empty List. Nothing to Remove");
            }
            //Check if Cursor is the last Node
            else if(Cursor.Next==null)
            {
                throw new InvalidOperationException("Last Node in List. Nothing to Remove After");
            }
            else
            {
                //Get the node to be removed
                Node<T> removed = Cursor.Next;

                //get the node that will be after the cursor once removed is gone
                Node<T> newNext = removed.Next;

                //get cursor to point to the new next
                Cursor.Next = newNext;

                //get the new next node to recognize cursor as its prev node
                newNext.Previous = Cursor;

                //Update Next and Prev Pointer for new node to unlink it from list
                removed.Next = null;
                removed.Previous = null;

                //Decrease size
                size --;

                //return the removed node
                return removed;
            }
        }

        public Node<T> RemoveBefore(Node<T> Cursor)
        {
            //Check if the list is empty
            if (size == 0)
            {
                throw new InvalidOperationException("Empty List. Nothing to Remove");
            }
            //Check if Cursor is the first Node
            else if (Cursor == Head)
            {
                throw new InvalidOperationException("First Node in List. Nothing to Remove Before");
            }
            else
            {
                //Get the node to remove
                Node<T> removedNode = Cursor.Previous;

                //Check if the node to remove is the head
                if(removedNode == Head)
                {
                    //Make the cursor the new head
                    Head = Cursor;
                    
                    //remove all pointers to removed node
                    Cursor.Previous = null;
                    removedNode.Next = null;
                }
                else
                {
                    //Get the node before the one to remove
                    Node<T> prevToremoved = removedNode.Previous;

                    //Link Cursor and previous to removed to bypass removed node
                    Cursor.Previous = prevToremoved;
                    prevToremoved.Next = Cursor;

                    //remove all pointers to removed node
                    removedNode.Previous = null;
                    removedNode.Next = null;
                }

                //Decrease the size
                size--;
                //return the removed node
                return removedNode;
            }
        }

        public Node<T> RemoveLast()
        {
            //Check if list is empty - if Yes no Nodes to remove
            if (isEmpty() == true)
            {
                throw new InvalidOperationException("Empty List No Nodes to Remove");
            }
            else
            {
                //Create a Pointer to the last Node in the list
                Node<T> lastNode;

                //If only 1 node in list
                if (GetSize() == 1)
                {
                    //Last Node in List should Point To Head
                    lastNode = Head; 
                    //Head should Point To Null as there are no other nodes
                    Head = null;
                }
                else
                {
                    //Look for the last node - has Next Pointer equal to null
                    //Start looking from the start of the list
                    lastNode = Head;

                    //While the node we are looking at is not the last one
                    while (lastNode.Next != null)
                    {
                        //Move to the next node
                        lastNode = lastNode.Next;
                    }//Once this loop is over, last node is struly equal to the last node in the list

                    //Get the node before the last one
                    Node<T> nodeBeforeLast = lastNode.Previous;

                    //Set the  next pointer for the node before last to null
                    nodeBeforeLast.Next = null;

                    //Set the previous pointer for the last node to null to isolate it from the list
                    lastNode.Previous = null;
                }

                //Decrease the Size
                size--;

                //Return the node taht was at the end of the list
                return lastNode;
            }
        }
    }
}
