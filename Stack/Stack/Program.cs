using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();
            myStack.Push("Item1");
            myStack.Push("Item2");
            myStack.Push("Item3");
            myStack.Push("Item4");
            myStack.Push("Item5");
            myStack.Push("Item6");
            myStack.Push("Item7");
            myStack.Push("Item8");
            myStack.Push("Item9");
            myStack.Push("Item10");

            Console.WriteLine("Initial stack count : " + myStack.Count);
            Console.WriteLine();

            while (myStack.Count >0)
            {
                Object item = myStack.Pop();
                Console.WriteLine("Popped " + item.ToString() + " off the stack");
                Console.WriteLine("Stack count : " + myStack.Count);
                Console.WriteLine();

            }

        }
    }
}
