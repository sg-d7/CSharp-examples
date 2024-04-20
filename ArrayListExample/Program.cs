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
            ArrayList list = new ArrayList();
            for (int i = 0; i < 10; i++)
            {
                list.Add("Alma");
                list.Add(i);
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write("Item " + (i + 1).ToString());
                Console.Write(" Type: " + list[i].GetType().ToString());
                Console.WriteLine(", " + list[i].ToString());
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
