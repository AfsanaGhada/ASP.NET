using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_7
{
    internal class Stack_opration
    {
        public void stack_demo()
        {
            Stack<int> stack = new Stack<int>();

            // Push items
            stack.Push(100);
            stack.Push(200);
            Console.WriteLine("After Pushing: " + string.Join(", ", stack));

            // Pop item
            Console.WriteLine("Popped: " + stack.Pop());

            // Peek item
            Console.WriteLine("Peek: " + stack.Peek());

            // Check contains
            Console.WriteLine("Contains 20: " + stack.Contains(20));

            // Clear items
            stack.Clear();
            Console.WriteLine("After Clearing: Count = " + stack.Count);
        }
    }
}
