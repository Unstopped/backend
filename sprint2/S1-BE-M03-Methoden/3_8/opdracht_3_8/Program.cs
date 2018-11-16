using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_3_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int random = rnd.Next(1, 100);
            Console.WriteLine("geef je voornaam:");
            string vnaam = Console.ReadLine();
            Console.WriteLine("geef je achternaam:");
            string anaam = Console.ReadLine();
            Console.Write(vnaam.Substring(0, 1)+anaam+random);
            Console.ReadKey();
        }
    }
}
