using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    class Opdracht1
    {
        static void Main(string[] args)
        {
            int[] getallen;
            getallen = new int[3];
            Console.WriteLine("3 getallen aub: ");
            getallen[0] = Convert.ToInt32(Console.ReadLine());
            getallen[1] = Convert.ToInt32(Console.ReadLine());
            getallen[2] = Convert.ToInt32(Console.ReadLine());
            int resultaat = getallen[0] + getallen[1] + getallen[2];
            Console.WriteLine("De getallen opgeteld zijn: {0} + {1} + {2} = {3}", getallen[0], getallen[1], getallen[2], resultaat);
            Console.ReadKey();
        }
    }
}
