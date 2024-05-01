using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // arraylist declaration
            ArrayList list = new ArrayList();
            for (int i = 0; i < 10; i++)
            {
                // adding new itemst to the list
                list.Add("Alma");
                list.Add(i);
                // adding two different kind of data
            }

            for (int i = 0; i < list.Count; i++)
            {
                // print the list content and type
                Console.Write("Item " + (i + 1).ToString());
                Console.Write(" Type: " + list[i].GetType().ToString());
                Console.WriteLine(", " + list[i].ToString());
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            // delete string data from list
            for (var i = (list.Count - 1); i >= 0; i--)
            {
                if (list[i].GetType() == typeof(string))
                {
                    Console.WriteLine("Item deleted: " + list[i].ToString() + ", item index: " + i.ToString());
                    list.RemoveAt(i);
                }
            }

            // print the list content
            for (var i = 0; i < list.Count; i++)
            {
                // print the list content and type
                Console.Write("Item " + (i + 1).ToString());
                Console.Write(" Type: " + list[i].GetType().ToString());
                Console.WriteLine(", " + list[i].ToString());
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
