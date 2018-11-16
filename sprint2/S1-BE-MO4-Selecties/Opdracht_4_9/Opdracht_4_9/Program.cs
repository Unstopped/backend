using System;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;

namespace Opdracht_4_9
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
                    Console.WriteLine("wat is de nummer van de maand?");
                    input = Console.ReadLine();
                } while (int.TryParse(input, out n) == false);
                if (n < 13 && n > 0)
                {
                    Console.Clear();
                    string datum = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(n);
                    Console.WriteLine("De datum is: " + datum);
                    Console.WriteLine("Druk op enter om verder te gaan");
                    Console.ReadKey();

                    if (key.Key == ConsoleKey.Enter)
                    {
                        done = true;
                    }

                }
                else
                {
                    Console.WriteLine("je kan alleen maar nummers van 1 tm 12 invoeren");
                    Console.ReadKey();
                }
            }
        }
    }
}
