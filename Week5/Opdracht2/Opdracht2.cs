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
            int[] getallen;
            getallen = new int[9];
            Console.WriteLine("9 getallen aub: ");
            getallen[0] = Convert.ToInt32(Console.ReadLine());
            getallen[1] = Convert.ToInt32(Console.ReadLine());
            getallen[2] = Convert.ToInt32(Console.ReadLine());
            getallen[3] = Convert.ToInt32(Console.ReadLine());
            getallen[4] = Convert.ToInt32(Console.ReadLine());
            getallen[5] = Convert.ToInt32(Console.ReadLine());
            getallen[6] = Convert.ToInt32(Console.ReadLine());
            getallen[7] = Convert.ToInt32(Console.ReadLine());
            getallen[8] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Welk getal wilt u zien? ");
            int gevraagd = Convert.ToInt32(Console.ReadLine());
            int antwoord = getallen[gevraagd];
            Console.WriteLine("Het getal op positie {0} is {1}", gevraagd, antwoord);
            Console.ReadKey();
        }
    }
}
