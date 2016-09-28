using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2
{
    class Opdracht2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welke taal wil je kiezen: Nederlands, Engels, Frans, Fries of Duits.");
            Console.Write("Taal: ");
            string taal = Console.ReadLine();
            switch (taal) {
                case "Nederlands":
                    Console.WriteLine("Tot Ziens");
                    break;
                case "Engels":
                    Console.WriteLine("Cya");
                    break;
                case "Frans":
                    Console.WriteLine("Au Revoir");
                    break;
                case "Fries":
                    Console.WriteLine("Oant Sjen");
                    break;
                case "Duits":
                    Console.WriteLine("Auf Wiedersehen");
                    break;
                default:
                    Console.WriteLine("Deze taal wordt niet herkent.");
                    break;
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}