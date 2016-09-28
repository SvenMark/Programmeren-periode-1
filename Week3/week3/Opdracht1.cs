using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    class Opdracht1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoe oud ben je?");
            int jaar = Convert.ToInt32(Console.ReadLine());
            if (jaar >= 21)
            {
                Console.WriteLine("Je krijgt toegang tot onze exclusieve VIP-lounge!");
                Console.WriteLine("Met hoeveel personen zijt gij?");
                int pers = Convert.ToInt32(Console.ReadLine());
                switch (pers)
                {
                    case 3:
                        Console.WriteLine("Een groep van {0} personen krijgt: 10% korting.", pers);
                        break;
                    case 4:
                        Console.WriteLine("Een groep van {0} personen krijgt: 20% korting.", pers);
                        break;
                    case 5:
                        Console.WriteLine("Een groep van {0} personen krijgt: 50% korting.", pers);
                        break;
                    default:
                        if (pers > 6)
                        {
                            Console.WriteLine("Een groep van {0} personen krijgt: Gratis entree.", pers);
                        }
                        else
                        {
                            Console.WriteLine("Geen korting voor een groep van {0} personen", pers);
                        }
                        break;
                }
            }
            else if (jaar >= 16)
            {
                Console.WriteLine("Je bent {0} jaar oud. Veel plezier in de Versus.", jaar);
                Console.WriteLine("Met hoeveel personen zijt gij?");
                int pers = Convert.ToInt32(Console.ReadLine());
                switch (pers)
                {
                    case 3:
                        Console.WriteLine("Een groep van {0} personen krijgt: 10% korting.", pers);
                        break;
                    case 4:
                        Console.WriteLine("Een groep van {0} personen krijgt: 20% korting.", pers);
                        break;
                    case 5:
                        Console.WriteLine("Een groep van {0} personen krijgt: 50% korting.", pers);
                        break;
                    default:
                        if (pers > 6)
                        {
                            Console.WriteLine("Een groep van {0} personen krijgt: Gratis entree.", pers);
                        }
                        else
                        {
                            Console.WriteLine("Geen korting voor een groep van {0} personen", pers);
                        }
                        break;
                }
            }
            else
            {
                Console.WriteLine("Helaas! Je moet minimaal 16 jaar zijn om toegang te krijgen tot de Versus.");
            }
            if (jaar > 16)
            {
                Console.WriteLine("Ladies Night: ");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                if (jaar > 30 && jaar > 16)
                {
                    Console.WriteLine("Wat is uw geslacht?");
                    string gender = Console.ReadLine();
                    if (gender == "vrouw")
                    {
                        Console.WriteLine("Is het vandaag de eerste woensdag van de maand?");
                        string woensdag = Console.ReadLine();
                        if (woensdag == "ja")
                        {
                            Console.WriteLine("Bent u ongehuwd?");
                            string huw = Console.ReadLine();
                            if (huw == "ja")
                            {
                                Console.WriteLine("U krijgt hierbij toegang tot de Ladies Night");
                            }
                            else
                            {
                                Console.WriteLine("De Ladies Night is alleen voor ongehuwde vrouwen.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Helaas er is vandaag geen ladies night");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Mannen zijn niet toegestaan op de Ladies Night");
                    }
                }
                else
                {
                    Console.WriteLine("U bent ouder dan 30 of jonger dan 16 en dus krijgt u geen toegang tot de Ladies Night");
                }
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}