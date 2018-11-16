using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            int n;
            string input;
            ConsoleKeyInfo key;
            while (!done)
            {
                do
                {
                    key = Console.ReadKey(true);
                    Console.WriteLine("voer een nummer in?");
                    input = Console.ReadLine();
                } while (int.TryParse(input, out n) == false);
                if (n < 5 && n > 0)
                {
                    Console.Clear();
                    int nummer = n;
                    if (nummer == 1)
                    {
                        Console.WriteLine("Klaver");

                    }
                    if (nummer == 2)
                    {
                        Console.WriteLine("Ruiten");

                    }
                    if (nummer == 3)
                    {
                        Console.WriteLine("Harten");

                    }
                    if (nummer == 4)
                    {
                        Console.WriteLine("Schoppen");

                    }
                    Console.WriteLine("Druk op enter om verder te gaan");
                    Console.ReadKey();

                    if (key.Key == ConsoleKey.Enter)
                    {
                        done = true;
                    }

                }
                else
                {
                    Console.WriteLine("je kan alleen maar nummers van 1 tm 4 invoeren");
                    Console.ReadKey();
                }

            }
        }
    }
}
