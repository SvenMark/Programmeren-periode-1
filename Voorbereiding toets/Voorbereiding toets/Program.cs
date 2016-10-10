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
            double[] getallen = new double[3];
            for (int i = 0; i < getallen.Length; i++)
            {
                Console.Write("Getal {0}: ", i + 1);
                getallen[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine(getallen.Average());            
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
            Array.Reverse(getallen);
            foreach (int i in getallen)
            {
                Console.WriteLine(i);
            }
        }
        // vraag3:  
        // enter 3 getalen en print de klein getal uit.
        public static void vraag3()
        {
            int[] getallen = new int[3];
            for (int i = 0; i < getallen.Length; i++)
            {
                Console.Write("Getal {0}: ", i + 1);
                getallen[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(getallen.Min());
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
