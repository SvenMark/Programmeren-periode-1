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
            //fibonogwat
            int f0 = 0;
            Console.Write(" {0}", f0);
            int f1 = 1;
            Console.Write(" {0}", f1);
            for (int n = 2; n<10; n++)
            {
                int fn = f0 + f1;
                Console.Write(" {0}", fn);
                f0 = f1;
                f1 = fn;
            }
            Console.ReadKey();
        }
    }
}
