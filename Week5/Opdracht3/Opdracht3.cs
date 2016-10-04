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
            int[] getallen;
            getallen = new int[10];
            Console.WriteLine("10 getallen aub: ");
            for (int i = 0; i < getallen.Length; i++)
            {
                getallen[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Array.Sort(getallen);
            for (int count = 0; count < 10; count++)
            {
                if (getallen[count] % 2 == 0)
                {
                    Console.WriteLine(getallen[count]);
                }
            }
            Console.ReadKey();
        }
    }
}
