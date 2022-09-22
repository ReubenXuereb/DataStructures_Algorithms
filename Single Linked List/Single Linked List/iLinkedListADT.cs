using System;
using System.Collections.Generic;
using System.Text;

namespace Single_Linked_List
{
    interface iLinkedListADT
    {
        //Return 
       Node getNextNode(Node cur);
       Node getPrevNode(Node cur);

        //Insert
       void insertAfter(Node cur, int v);
       void insertBefore(Node cur, int v);
       void Insert(int v);

        //Remove
       int Remove(Node cur);
       int removeAfter(Node cur);
       int removeBefore(Node cur);





    }
}
