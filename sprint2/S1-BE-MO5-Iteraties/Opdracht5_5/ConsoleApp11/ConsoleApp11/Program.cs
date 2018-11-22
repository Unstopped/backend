using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            for (int i = 100; i < 1001; i++)
            {
                total = total + i;
            }
            Console.WriteLine("de som van 100tm1000 is: " + total);
            Console.ReadKey();

        }
    }
}
