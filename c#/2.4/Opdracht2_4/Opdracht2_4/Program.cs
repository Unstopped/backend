using System;
namespace Opdracht2_4
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("geboorte datum");
                Console.WriteLine("--------------");
                Console.WriteLine("naam:");
                string naam = Console.ReadLine();

                if (naam != "" && naam != "naam:")
                {
                    Console.Clear();
                    Console.WriteLine("geboorte datum");
                    Console.WriteLine("--------------");
                    Console.WriteLine("dag:");
                    int dag = Convert.ToInt32(Console.ReadLine());
                    if (dag > 0)
                    {
                        Console.Clear();
                        Console.WriteLine("geboorte datum");
                        Console.WriteLine("--------------");
                        Console.WriteLine("maand:");
                        int maand = Convert.ToInt32(Console.ReadLine());
                        if (maand > 0)
                        {
                            Console.Clear();
                            Console.WriteLine("geboorte datum");
                            Console.WriteLine("--------------");
                            Console.WriteLine("jaar:");
                            int jaar = Convert.ToInt32(Console.ReadLine());
                            if (jaar > 0)
                            {
                                Console.Clear();
                                var vandaag = DateTime.Today;
                                var vandaagberekening = (DateTime.Today.Year * 100 + DateTime.Today.Month) * 100 + DateTime.Today.Day;
                                var geboortedatumberekening = (jaar * 100 + maand) * 100 + dag;
                                var leeftijd = (vandaagberekening - geboortedatumberekening) / 10000;
                                Console.WriteLine(naam);
                                Console.WriteLine(leeftijd);

                            }
                        }
                    }
                }
            }
        }
    }
}


