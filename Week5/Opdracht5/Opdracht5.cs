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
            Console.Write("Hoeveel namen heb je? ");
            int leerlingen = Convert.ToInt32(Console.ReadLine());
            string[] namen;
            namen = new string[leerlingen];
            for (int i = 0; i < leerlingen; i++)
            {
                Console.Write("Naam {0}: ", i+1);
                namen[i] = Console.ReadLine();
                Console.WriteLine();
            }

            Console.Write("Er zijn {0} leerlingen: {1}", leerlingen, namen[0]);

            for (int i = 1; i < leerlingen; i++ )
            {
                Console.Write(", {0}", namen[i]);
            }
            Console.ReadKey();
        }
    }
}
