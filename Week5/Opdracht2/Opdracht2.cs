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
            for (int i = 0; i < getallen.Length; i++)
            {
                getallen[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Welk getal wilt u zien? ");
            int gevraagd = Convert.ToInt32(Console.ReadLine());
            int antwoord = getallen[gevraagd - 1];
            Console.WriteLine("Het getal op positie {0} is {1}", gevraagd, antwoord);
            Console.ReadKey();
        }
    }
}
