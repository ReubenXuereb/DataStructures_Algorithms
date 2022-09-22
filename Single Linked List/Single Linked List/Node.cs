using System;
using System.Collections.Generic;
using System.Text;

namespace Single_Linked_List
{
    class Node
    {
        private int value;
        private Node next;

        public int Value { get => value; set => this.value = value; }
        public Node Next { get => next; set => next = value; }

        public Node(int v)
        {
            this.value = v;
        }
    }
}
