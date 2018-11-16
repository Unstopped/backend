using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lengte:");
            double lengte = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("breedte:");
            double breedte = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("hoogte:");
            double hoogte = Convert.ToInt32(Console.ReadLine());
            double antwoord = (hoogte * lengte) * breedte;
            Console.WriteLine(Convert.ToInt32(antwoord) + " centimeter");
            Console.WriteLine(Convert.ToInt32((antwoord) / 1000) + " liter");
        }
    }
}
