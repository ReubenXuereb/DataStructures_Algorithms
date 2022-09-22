using System;

namespace Single_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
           Stack s = new Stack();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);
            s.Push(5);

            Console.WriteLine(s.Pop());
      
        }
    }
}
