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
            Console.WriteLine("10 machten van 2: ");
            for (int count = 0; count < 10; count++)
            {
                Console.WriteLine(Math.Pow(2, count));
                //Console.WriteLine(count);
            }
            Console.ReadKey();
        }
    }
}
