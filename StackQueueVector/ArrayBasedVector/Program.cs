using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayBasedVector
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create the stack
            InvertedVectorStack stack = new InvertedVectorStack(5);

            //Insert Elements
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            //CHeck first element
            Console.WriteLine("\n\nRemoving Elements from Stack");
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.ReadKey();
            
        }
    }
}
