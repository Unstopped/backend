using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht5_15
{
    class Program
    {

        static void Main(string[] args)
        {
            string original= Console.ReadLine();
            var reversed = new string(original.Reverse().ToArray());
            if (original == reversed)
            {
                Console.WriteLine(original + "  is een palindroom");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(original + "  is geen palindroom");
                Console.ReadKey();
            }

        }
    }
}
                                                                                                                                                    