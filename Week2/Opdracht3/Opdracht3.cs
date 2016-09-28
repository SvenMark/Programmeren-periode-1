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
            float a = 1337F;
            float b = 420F;
            float c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine("A: " + a);
            Console.WriteLine("B: " + b);
            Console.ReadLine();
        }
    }
}
