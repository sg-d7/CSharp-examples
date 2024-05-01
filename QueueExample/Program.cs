using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueExample
{
    class Program
    {
        // Example for the FIFO
        private static Queue que = new Queue();
        static void Main(string[] args)
        {
            var rnd = new Random();
            Console.WriteLine("Fill up que with 10 number");
            for (var i = 0; i < 10; i++)
            {
                // add random numbers to the que
                var num = rnd.Next(Int16.MinValue, Int16.MaxValue);
                que.Enqueue(num);
            }
            Console.WriteLine("Queue size: " + que.Count.ToString());
            Console.WriteLine("Press any key to read items from the que...");
            Console.ReadKey();

            while (que.Count > 0)
            {
                var num = (int)que.Dequeue();
                Console.WriteLine("Item: " + num.ToString() + " removed from que");
            }

            Console.WriteLine("Queue size: " + que.Count.ToString());
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
