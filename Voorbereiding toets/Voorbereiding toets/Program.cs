using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
 {    // vraag1: schrijf een programma die je drie getalen invoeren en reken de gemiddelde er van
        public static void vraag1()
        {
            double getallen = 0;
            double getal = 0;
            double gem = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Getal {0}: ", i + 1);
                getal = Convert.ToDouble(Console.ReadLine());
                getallen += getal;
            }
            gem = getallen / 3;
            Console.WriteLine("Gemiddelde: {0}", gem);
        }
     // vraag2:
     // declare een array getalen die heeft size7 
    // vul de array met getalen 
   //print de inhoud van de array 
  // print de array van achter naar voeren 
        public static void vraag2()
        {
            int[] getallen = new int[7];
            for (int i = 0; i < getallen.Length; i++)
            {
                Console.Write("Getal {0}: ", i + 1);
                getallen[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Reversed: ");
            for (int j = getallen.Length - 1; j >= 0; j--)
            {
                Console.WriteLine(getallen[j]);
            }
        }
        // vraag3:  
        // enter 3 getalen en print de klein getal uit.
        public static void vraag3()
        {
            Console.Write("Getal 1: ");
            int smallest = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 3; i++)
            {
                Console.Write("Getal {0}: ", i + 1);
                int getallen = Convert.ToInt32(Console.ReadLine());
                if (getallen < smallest)
                {
                    smallest = getallen;
                }
            }
            Console.WriteLine(smallest);
        }
        static void Main(string[] args)
        {
            //vraag1();
            //vraag2();
            //vraag3();
            Console.ReadLine();
        }
    }
}
