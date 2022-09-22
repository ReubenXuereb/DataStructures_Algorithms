using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class Node
    {
        private int value;
        private Node left;
        private Node right;

        public int Value { get => value; set => this.value = value; }
        internal Node Left { get => left; set => left = value; }
        internal Node Right { get => right; set => right = value; }

        public Node (int v)
        {
            Value = v;
        }
    }
}
