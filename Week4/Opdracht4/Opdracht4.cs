using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4
{
    class Opdracht4
    {
        static void Main(string[] args)
        {
            double input_km = 0;
            double input_liter = 1;
            double km = 0;
            double liter = 0;
            while (input_liter != 0)
            {
                Console.WriteLine("Hoeveel km heeft u gereden sinds de vorige tankbeurt? ");
                input_km = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Hoeveel liter heeft u getankt? ");
                input_liter = Convert.ToInt32(Console.ReadLine());
                km += input_km;
                liter += input_liter;
            }

            double gem_verbruik = (liter / km) * 100;
            Console.WriteLine("U verbruik gemiddeld {0} liter per 100km", Math.Round(gem_verbruik));
            Console.ReadKey();
        }
    }
}
