using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("leeftijd berekenen");
            int check = 1;
            while (true)
            {
                if (check == 1)
                {
                    Console.WriteLine("naam:");
                    string naam = Console.ReadLine();
                    Console.WriteLine("dag:");
                    int dag = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("maand:");
                    int maand = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("jaar:");
                    int jaar = Convert.ToInt32(Console.ReadLine());
                    var vandaag = DateTime.Today;
                    var vandaagberekening = (DateTime.Today.Year * 100 + DateTime.Today.Month) * 100 + DateTime.Today.Day;
                    var geboortedatumberekening = (jaar * 100 + maand) * 100 + dag;
                    var leeftijd = (vandaagberekening - geboortedatumberekening) / 10000;
                    Console.Clear();
                    Console.WriteLine(naam);
                    Console.WriteLine(leeftijd);
                    check = 2;
                }
            }
        }
    }
}
