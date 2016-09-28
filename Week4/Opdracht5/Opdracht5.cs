using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht5
{
    class Opdracht5
    {
        static void Main(string[] args)
        {
            start:
            Console.Write("Inzet(min 5EUR, max 100EUR, 0 for exit): ");
            int inzet = Convert.ToInt32(Console.ReadLine());
            int checkout = 0;
            int aantal_zes = 0;
            if (inzet >= 5 && inzet <= 100)
            {
                Random Dobbelsteen = new Random();
                for (int i = 1; i <= 3; i++)
                {
                    int Gooi_dob1 = Dobbelsteen.Next(1, 7);
                    int Gooi_dob2 = Dobbelsteen.Next(1, 7);
                    //int Gooi_dob1 = 6;
                    //int Gooi_dob2 = 5;
                    if (Gooi_dob1 == 6 || Gooi_dob2 == 6)
                    {
                        aantal_zes += 1;
                    }
                    Console.WriteLine("Gooi {0}: {1}, {2}", i, Gooi_dob1, Gooi_dob2);
                    Console.ReadLine();
                    if (Gooi_dob1 == 6 && Gooi_dob2 == 6)
                    {
                        checkout += inzet * 50;
                        int winst = inzet * 50;
                        Console.WriteLine("U wint: {0}EUR", winst);
                        //break;
                    }
                    else if (Gooi_dob1 == Gooi_dob2)
                    {
                        checkout += inzet * 10;
                        int winst = inzet * 10;
                        Console.WriteLine("U wint: {0}EUR", winst);
                        //break;
                    }
                    else if (aantal_zes >= 2)
                    {
                        checkout += inzet * 2;
                        int winst = inzet * 2;
                        Console.WriteLine("U wint: {0}EUR", winst);
                        Console.ReadKey();
                    }
                }
            }
            else
            {
                Console.WriteLine("Jammer dat u niet nog een keer wilt spelen. Press any key to exit.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            if (checkout == 0)
            {
                Console.WriteLine("Helaas niks gewonnen. Press any button to play again.");
                Console.ReadKey();
                goto start;
            }
            Console.WriteLine("U heeft in totaal gewonnen: {0}", checkout);
            Console.WriteLine("Press any button to try again.");
            Console.ReadKey();
            goto start;
        }
    }
}
