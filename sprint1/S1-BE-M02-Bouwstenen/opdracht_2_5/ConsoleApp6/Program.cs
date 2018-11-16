using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string check = "b";
            while(check == "b")
            {

            
                Console.Clear();
                double eindprijs = 0;
                double prijs = 0;



                string lak = "";
                string bekleding = "";
                string automaat = "";
                Console.WriteLine("prijs:");
                prijs = Convert.ToInt32(Console.ReadLine());

                if (prijs > 0)
                {
                    Console.Clear();
                    Console.WriteLine("Metalic lak? ja/nee");
                    lak = Console.ReadLine();

                    if (lak == "ja" || lak == "nee")
                    {
                        Console.Clear();
                        Console.WriteLine("Leren bekleding? ja/nee");
                        bekleding = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("je kan niet iets anders antwoorden dan ja of nee");
                        Console.WriteLine("type (b) als je  verder wilt of enter als je wilt stoppen");
                        check = Console.ReadLine();
                        if (check == "a")
                        {

                        }
                    }
                    if (bekleding == "ja" || bekleding == "nee" || check != "a")
                    {
                        Console.Clear();
                        Console.WriteLine("automaat? ja/nee");
                        automaat = Console.ReadLine();

                    }
                    else
                    {
                        Console.WriteLine("je kan niet iets anders antwoorden dan ja of nee");
                        Console.WriteLine("type (b) als je  verder wilt of enter als je wilt stoppen");
                        check = Console.ReadLine();
                        if (check == "a")
                        {

                        }
                    }
                    if (automaat == "ja" || automaat == "nee" || check != "a")
                    {
                        eindprijs = prijs;
                        Console.Clear();
                        if (lak == "ja")
                        {
                            eindprijs = eindprijs + prijs * 0.5;
                        }
                        if (automaat == "ja")
                        {
                            eindprijs = eindprijs + 1000;

                        }
                        if (bekleding == "ja")
                        {
                            eindprijs =  eindprijs + prijs * 0.5;

                        }
                        eindprijs = eindprijs + (eindprijs * 0.21);
                        Console.WriteLine(eindprijs);
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("je kan niet iets anders antwoorden dan ja of nee");
                        Console.WriteLine("type (b) als je  verder wilt of enter als je wilt stoppen");
                        check = Console.ReadLine();
                        if (check == "a")
                        {

                        }
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("de getal mag niet 0 of lager zijn");
                    Console.WriteLine("type (b) als je  verder wilt of enter als je wilt stoppen");
                    check = Console.ReadLine();
                    if (check == "a")
                    {

                    }
                }

            }
        }
    }       
}
