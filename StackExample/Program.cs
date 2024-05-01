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
        // this demonstrate LIFO working method
        private static Stack stack = new Stack();
        static void Main(string[] args)
        {
            var rnd = new Random();
            Console.WriteLine("Fill up que with 10 number");
            for (var i = 0; i < 10; i++)
            {
                // add random numbers to the stack
                var num = rnd.Next(Int16.MinValue, Int16.MaxValue);
                stack.Push(num);
                Console.WriteLine("Add item to stack: " + num.ToString());
            }
            Console.WriteLine("Queue size: " + stack.Count.ToString());
            Console.WriteLine("Press any key to read items from the stack...");
            Console.ReadKey();

            while (stack.Count > 0)
            {
                var num = (int)stack.Pop();
                Console.WriteLine("Item: " + num.ToString() + " removed from stack");
            }

            Console.WriteLine("Stack size: " + stack.Count.ToString());
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
