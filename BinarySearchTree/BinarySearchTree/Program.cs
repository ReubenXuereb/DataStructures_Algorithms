using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Insert(8, tree.Root);
            bool found = tree.Search(8, tree.Root);
        }
    }
}
