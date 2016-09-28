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
            getallen[0] = Convert.ToInt32(Console.ReadLine());
            getallen[1] = Convert.ToInt32(Console.ReadLine());
            getallen[2] = Convert.ToInt32(Console.ReadLine());
            getallen[3] = Convert.ToInt32(Console.ReadLine());
            getallen[4] = Convert.ToInt32(Console.ReadLine());
            getallen[5] = Convert.ToInt32(Console.ReadLine());
            getallen[6] = Convert.ToInt32(Console.ReadLine());
            getallen[7] = Convert.ToInt32(Console.ReadLine());
            getallen[8] = Convert.ToInt32(Console.ReadLine());
            getallen[9] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
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
