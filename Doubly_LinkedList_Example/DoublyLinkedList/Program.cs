using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<int> mylist = new DoublyLinkedList<int>();
            try
            {
                //Check Initial Size and State of List
                Console.WriteLine("Size: " + mylist.GetSize());
                Console.WriteLine("Empty: " + mylist.isEmpty());

                //Insert some nodes in list
                mylist.InsertLast(1);
                mylist.InsertLast(3);
                mylist.InsertLast(4);
                mylist.InsertAfter(2, mylist.Head);
                mylist.InsertFirst(0);
                
                //Check Size and State of List after Inserts
                Console.WriteLine("Size: " + mylist.GetSize());
                Console.WriteLine("Empty: " + mylist.isEmpty());

                //Remove First and Last Node
                Node<int> removeFirst = mylist.RemoveFirst();
                Console.WriteLine("First Node Removed : "+removeFirst.element);
                Node<int> removeLast = mylist.RemoveLast();
                Console.WriteLine("Last Node Removed : " + removeLast.element);

                //Check Size and State of List after Remove
                Console.WriteLine("Size: " + mylist.GetSize());
                Console.WriteLine("Empty: " + mylist.isEmpty());

                //Keep on removing nodes until only one is left
                removeFirst = mylist.RemoveFirst();
                Console.WriteLine("First Node Removed : " + removeFirst.element);
                removeLast = mylist.RemoveLast();
                Console.WriteLine("Last Node Removed : " + removeLast.element);

                Console.WriteLine("Size: " + mylist.GetSize());
                Console.WriteLine("Empty: " + mylist.isEmpty());

                //Try to remove the last remaining node
                removeFirst = mylist.RemoveFirst();
                Console.WriteLine("First Node Removed : " + removeFirst.element);

                Console.WriteLine("Size: " + mylist.GetSize());
                Console.WriteLine("Empty: " + mylist.isEmpty());

                //Try to remove a node when no mor enodes are available
                removeFirst = mylist.RemoveFirst();
                Console.WriteLine("First Node Removed : " + removeFirst.element);

                Console.WriteLine("Size: " + mylist.GetSize());
                Console.WriteLine("Empty: " + mylist.isEmpty());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();

        }
    }
}
