using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programmeren
{
    class opgave1_2
    {
        static void Main(string[] args)
        {
            //opgave 1A
            string Naam = "Fiona";
            char Variable1 = 'C';
            int Nummer1 = 123;
            double Nummer2 = 1.5;
            bool Status = false;
            int Leeftijd = 35;
            double Rest = Nummer1 / Nummer2;
            //opgave 2A
            string woordA = "Hallo";
            string woordB = "wereld";
            string zin = woordA + " " + woordB;
            string bla = "bla";
            //opgave 1B
            Console.WriteLine(Naam + " " + Variable1);
            Console.WriteLine(Nummer1 + " " + Nummer2);
            Console.WriteLine(Leeftijd + " " + Status);
            Console.WriteLine(Rest);
            //opgave 2B
            Console.WriteLine(zin);
            Console.WriteLine(bla + bla + bla + bla + bla);
            //console leesbaar maken
            Console.ReadLine();
        }
    }
}
