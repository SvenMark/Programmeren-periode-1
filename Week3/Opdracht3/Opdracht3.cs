using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3
{
    class Opdracht3
    {
        static void Main(string[] args)
        {
            Console.Write("Wat is uw geslacht? ");
            string geslacht = Console.ReadLine();
            if (geslacht == "man")
            {
                Console.Write("Wat is uw lengte(cm)? ");
                double lengte = Convert.ToDouble(Console.ReadLine());
                lengte -= 100;
                lengte *= 0.9;
                int lengte_round = Convert.ToInt32(lengte);
                //Console.WriteLine(lengte);
                Console.WriteLine(lengte_round);
            }
            else if (geslacht == "vrouw")
            {
                Console.Write("Wat is uw lengte(cm)? ");
                double lengte = Convert.ToDouble(Console.ReadLine());
                Console.Write("Wat is uw polsomtrek(cm)? ");
                double pols = Convert.ToDouble(Console.ReadLine());
                double gewicht = (lengte + 4 * pols - 100) / 2;
                int gewicht_round = Convert.ToInt32(gewicht);
                //Console.WriteLine(gewicht);
                Console.WriteLine(gewicht_round);
            }
            else
            {
                Console.WriteLine("U no gender!?");
            }
            Console.ReadKey();
        }
    }
}
