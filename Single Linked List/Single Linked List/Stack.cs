using System;
using System.Collections.Generic;
using System.Text;

namespace Single_Linked_List
{
   
    class Stack
    {
        SingleLinkedListcs list = new SingleLinkedListcs();

        public void Push(int v)
        {
            //Insert in LiFo Order
            list.insertBefore(list.Head, v);
        }

        public int Pop()
        {
            //Remove & Return in LiFo Order
            return list.Remove(list.Head);
        }
    }
}
