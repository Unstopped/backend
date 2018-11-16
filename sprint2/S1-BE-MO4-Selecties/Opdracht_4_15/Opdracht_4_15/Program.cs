using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_4_15
{
    class Program
    {
        static void Main(string[] args)
        {
            bool checker1 = false;
            Console.WriteLine("Wiskunde");
            int wiskunde = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Schijkunde");
            int schijkunde = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Natuurkunde");
            int natuurkunde = Convert.ToInt32(Console.ReadLine());
            if (natuurkunde >= 60 || schijkunde >= 60)
            {
                checker1 = true;

            }
            if (wiskunde >= 60)
            {
                checker1 = true;
            }
            if (wiskunde + schijkunde + schijkunde == 180)
            {
                checker1 = true;
            }
            if (checker1 = true)
            {
                Console.Clear();
                Console.WriteLine("je bent geslaagd");
                Console.WriteLine("druk op enter om te stoppen");
                Console.ReadKey();
            }
        }
    }
}
