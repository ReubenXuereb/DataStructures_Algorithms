using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        private Node root;
        internal Node Root { get => root; set => root = value; }

        public void Insert(int v, Node start)
        {
            Node newNode = new Node(v);
        
            if(root == null)
            {
               newNode = root;
            }
               else
               {
                 if(v < start.Value)
                 {
                    start.Left = newNode;
                 }

                else
                {
                    Insert(v, start.Left);
                }

                if (v > start.Value)
                {
                    start.Right = newNode;
                }

                else
                {
                    Insert(v, start.Right);
                }
            }      
        }

        

        public bool Search(int v, Node start)
        {
            if (start == null)
            {
                return false;
            }

            else if (v == start.Value)
            {
                return true;
            }

            else
            {
                if(v < start.Value)
                {
                    Search(v, start.Left);
                }

                else if(v > start.Value)
                {
                    Search(v, start.Right);
                }
            }

        }
    }
}
