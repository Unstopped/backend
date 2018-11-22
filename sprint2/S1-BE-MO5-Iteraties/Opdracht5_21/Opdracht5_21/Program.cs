using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht5_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int totaal = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 5 == 0 || i % 3 == 0)
                {
                    totaal = totaal + i;
                    
                }
                
            }
            Console.WriteLine(totaal);
            Console.ReadKey();
        }
    }
}
