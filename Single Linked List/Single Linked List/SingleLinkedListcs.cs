using System;
using System.Collections.Generic;
using System.Text;

namespace Single_Linked_List
{
    class SingleLinkedListcs : iLinkedListADT
    {

        private Node head;
        public Node Head { get => head; set => head = value; }


        public Node getNextNode(Node cur)
        {
            if(head == null || cur == null)
            {
                throw new InvalidOperationException("Empty list or Null Pointer to Node Supplied");
            }
            else
            {
                return cur.Next;
            }
        }

        public Node getPrevNode(Node cur)
        {
            if (head == null || cur == null)
            {
                throw new InvalidOperationException("Empty list or Null Pointer to Node Supplied");
            }

            else if (cur == head)
            {
                return null; // nothing before the head
            }

            else
            {
                //Create a prev pointer to start from the head of the list
                Node prev = head;

                //While pre.next is not your cur node
                while (prev.Next != cur)
                {
                    //Move prev pointer to the next node
                    prev = prev.Next;
                }//Loop ends when prev is in the right spot

                return prev;
            }
        }

        public void Insert(int v)
        {
            throw new NotImplementedException();
        }

        public void insertAfter(Node cur, int v)
        {
            if(cur == null)
            {
                throw new InvalidOperationException("Null Pointer Supplied");
            }
            else
            {
                Node newNode = new Node(v);

                //If there is no value in the head pointer
                if(head == null)
                {
                    head = newNode;
                }
                else
                {
                    newNode.Next = cur.Next;
                    cur.Next = newNode;
                }
            }
        }

        public void insertBefore(Node cur, int v)
        {
            if (head == null)
            {
                Node newNode = new Node(v);
                head = newNode;
            }

            else if (cur == null)
            {
                throw new InvalidOperationException("Null Pointer Supplied");
            }

            else
            {
                Node newNode = new Node(v);


               if(cur == head)
                {
                    //link the new node to current node i.e Head
                    newNode.Next = cur;
                    //make the new node the head as it is now the first node in the list
                    head = newNode;
                }

                else
                {
                    //FInd the node before current
                    Node prev = getPrevNode(cur);
                    //Link the new node to the current one in the list
                    newNode.Next = cur;
                    //Link the prev node to the new node
                    prev.Next = newNode;
                }
            }
        }

        public int Remove(Node cur)
        {
            if(head == null || cur == null)
            {
                throw new InvalidOperationException("Empty List or NUll Ponter Supplied");
            }

            else if(cur == head)
            {
                //Store the value of the node to be removed in a temp var
                int temp = cur.Value;

                //Make the list start from the next node
                head = cur.Next;

                //Isolation of the current node from the list completely
                cur.Next = null;

                //retunring the value of the deleted node
                return temp;
            }

            else
            {
                int temp = cur.Value;

                //Find the node before the one to be removed
                Node prev = getPrevNode(cur);

                //link the prev node to the one after the cur node, so that the cur node is skipped
                prev.Next = cur.Next;

                //Isolate the current node from the list completely
                cur.Next = null;

                //returning the value of the deleted mpde
                return temp;
            }
        }

        public int removeAfter(Node cur)
        {
            return Remove(cur.Next);
        }

        public int removeBefore(Node cur)
        {
            Node prev = getPrevNode(cur);
            return Remove(prev);
        }
    }
}
