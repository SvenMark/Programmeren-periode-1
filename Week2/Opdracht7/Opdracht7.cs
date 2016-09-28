using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht7
{
    class Opdracht7
    {
        static void Main(string[] args)
        {
            Console.Write("Voornaam: ");
            string Voornaam = Console.ReadLine();
            
            Console.Write("Familienaam: ");
            string Familienaam = Console.ReadLine();
            
            Console.Write("Straat(zonder huisnummer): ");
            string Straat = Console.ReadLine();
            
            Console.Write("Huisnummer: ");
            string Huisnummer = Console.ReadLine();
            
            Console.Write("Postcode: ");
            string Postcode = Console.ReadLine();
            
            Console.Write("Gemeente: ");
            string Gemeente = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Voornaam: {0}", Voornaam);
            Console.WriteLine("Familienaam: {0}", Familienaam);
            Console.WriteLine("Straat: {0}", Straat);
            Console.WriteLine("Huisnummer: {0}", Huisnummer);
            Console.WriteLine("Postcode: {0}", Postcode);
            Console.WriteLine("Gemeente: {0}", Gemeente);

            Console.ReadLine();
        }
    }
}
