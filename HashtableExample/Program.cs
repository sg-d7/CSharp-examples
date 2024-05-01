using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashtableExample
{
    class Program
    {
        private static Hashtable assocarr = new Hashtable();
        static void Main(string[] args)
        {
            // addin continents area to the array [km2]
            // the source of the datas: https://fuggelek.foldrajzmagazin.hu/geoszferak/kontinensek-adatai/
            assocarr["Europe"] = 10508; 
            assocarr["Asia"] = 44411;
            assocarr["Africa"] = 30319;
            assocarr["America"] = 42549;
            assocarr["Australia"] = 8510;
            assocarr["Antarctica"] = 13328;

            // iterate through the assoc array
            Console.WriteLine("List the content of the associative array");
            foreach (DictionaryEntry item in assocarr)
            {
                string key = (string)item.Key;
                int area = (int)item.Value;
                Console.WriteLine("Continent {0} area is {1} km2", key, area);
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
